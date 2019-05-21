Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace E2442_UnboundDataFromDetail
	Partial Public Class Form1
		Inherits Form

		Private grid As GridControl = Nothing
		Private catView As GridView = Nothing
		Private prodView As GridView = Nothing

		Public Sub New()
			InitializeComponent()
		End Sub

		Private dataSet1 As New DataSet()
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			grid = New GridControl()
			grid.Parent = Me
			grid.Dock = DockStyle.Fill
			grid.ForceInitialize()

			Dim categories = DataHelper.CreateCategoriesTable()
			categories.TableName = "Categories"
			dataSet1.Tables.Add(categories)
			dataSet1.Tables.Add(DataHelper.CreateProductsTable())
			Dim keyColumn As DataColumn = dataSet1.Tables(0).Columns("CategoryID")
			Dim foreignKeyColumn As DataColumn = dataSet1.Tables(1).Columns("CategoryID")
			dataSet1.Relations.Add("CategoriesProducts", keyColumn, foreignKeyColumn)

			grid.MainView.Dispose()

			catView = New GridView(grid)
			prodView = New GridView(grid)

			grid.MainView = catView
			grid.LevelTree.Nodes.Add("CategoriesProducts", prodView)

			grid.DataSource = dataSet1.Tables(0)
			AddHandler catView.CustomUnboundColumnData, AddressOf OnUnboundColumnData

			Dim colIndex As Integer = catView.Columns.Add(New GridColumn())
			catView.Columns(colIndex).FieldName = "Field"
			catView.Columns(colIndex).UnboundType = UnboundColumnType.Decimal
			catView.Columns(colIndex).Caption = "Detail price sum"
			catView.Columns(colIndex).Visible = True
		End Sub

		Private Sub OnUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs)
			If Not e.IsGetData Then
				Return
			End If

			Dim pdc As PropertyDescriptorCollection = DirectCast(dataSet1.Tables(1).DefaultView, ITypedList).GetItemProperties(Nothing)
			Dim evaluator As New ExpressionEvaluator(pdc, prodView.ActiveFilterCriteria)

			Dim controllerRow As Integer = catView.DataController.GetControllerRow(e.ListSourceRowIndex)
			If Not catView.DataController.IsValidControllerRowHandle(controllerRow) Then
				Return
			End If

			Dim detailList As IList = catView.DataController.GetDetailList(controllerRow, 0)
			If detailList.Count = 0 Then
				Return
			End If

			Dim sum As Decimal = 0
			For i As Integer = 0 To detailList.Count - 1
				If evaluator.Fit(DirectCast(detailList(i), DataRowView)) Then
					sum += Convert.ToDecimal(DirectCast(detailList(i), DataRowView)("UnitPrice"))
				End If
			Next i

			e.Value = sum
		End Sub
	End Class
End Namespace