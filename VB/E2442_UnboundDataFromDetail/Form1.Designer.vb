Imports Microsoft.VisualBasic
Imports System
Imports E2442_UnboundDataFromDetail.nwindDataSetTableAdapters
Namespace E2442_UnboundDataFromDetail
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.nWindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New E2442_UnboundDataFromDetail.nwindDataSet()
			Me.categoriesTableAdapter = New E2442_UnboundDataFromDetail.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.productsTableAdapter = New E2442_UnboundDataFromDetail.nwindDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.nWindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nWindBindingSource
			' 
			Me.nWindBindingSource.DataSource = Me.nwindDataSet
			Me.nWindBindingSource.Position = 0
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(341, 295)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.nWindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private nWindBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private categoriesTableAdapter As CategoriesTableAdapter
		Private productsTableAdapter As ProductsTableAdapter
	End Class
End Namespace