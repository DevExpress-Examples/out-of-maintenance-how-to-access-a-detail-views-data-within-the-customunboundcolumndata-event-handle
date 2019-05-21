using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace E2442_UnboundDataFromDetail
{
	public partial class Form1 : Form
	{
		GridControl grid = null;
		GridView catView = null;
		GridView prodView = null;

		public Form1()
		{
			InitializeComponent();
		}

        DataSet dataSet1 = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
		{
			grid = new GridControl();
			grid.Parent = this;
			grid.Dock = DockStyle.Fill;
			grid.ForceInitialize();

            var categories = DataHelper.CreateCategoriesTable();
            categories.TableName = "Categories";
            dataSet1.Tables.Add(categories);
            dataSet1.Tables.Add(DataHelper.CreateProductsTable());
            DataColumn keyColumn = dataSet1.Tables[0].Columns["CategoryID"];
            DataColumn foreignKeyColumn = dataSet1.Tables[1].Columns["CategoryID"];
            dataSet1.Relations.Add("CategoriesProducts", keyColumn, foreignKeyColumn);

            grid.MainView.Dispose();

			catView = new GridView(grid);
			prodView = new GridView(grid);

			grid.MainView = catView;
			grid.LevelTree.Nodes.Add("CategoriesProducts", prodView);

            grid.DataSource = dataSet1.Tables[0];
			catView.CustomUnboundColumnData += new CustomColumnDataEventHandler(OnUnboundColumnData);

			int colIndex = catView.Columns.Add(new GridColumn());
			catView.Columns[colIndex].FieldName = "Field";
			catView.Columns[colIndex].UnboundType = UnboundColumnType.Decimal;
			catView.Columns[colIndex].Caption = "Detail price sum";
			catView.Columns[colIndex].Visible = true;
		}

        private void OnUnboundColumnData(object sender, CustomColumnDataEventArgs e)
		{
			if ( !e.IsGetData )
				return;

			PropertyDescriptorCollection pdc = ((ITypedList)dataSet1.Tables[1].DefaultView).GetItemProperties(null);
			ExpressionEvaluator evaluator = new ExpressionEvaluator(pdc, prodView.ActiveFilterCriteria);

			int controllerRow = catView.DataController.GetControllerRow(e.ListSourceRowIndex);
			if ( !catView.DataController.IsValidControllerRowHandle(controllerRow) )
				return;

			IList detailList = catView.DataController.GetDetailList(controllerRow, 0);
			if ( detailList.Count == 0 )
				return;

			decimal sum = 0;
			for ( int i = 0; i < detailList.Count; i++ )
				if ( evaluator.Fit((DataRowView)detailList[i]) )
					sum += Convert.ToDecimal(((DataRowView)detailList[i])["UnitPrice"]);

			e.Value = sum;
		}
	}
}