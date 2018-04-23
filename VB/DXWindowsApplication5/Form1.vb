Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Columns


Namespace DXWindowsApplication5
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()

			AddGridView()
			RegisterViewsInComboBox()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'countriesDBDataSet.Countries' table. You can move, or remove it, as needed.
			Me.countriesTableAdapter.Fill(Me.countriesDBDataSet.Countries)
		End Sub

		Private myGridView As GridView

		Private Sub AddGridView()
			myGridView = New GridView(gridControl1)
			myGridView.ViewCaption = "Table"


			Dim fieldNames() As String = { "Country", "Capital", "Currency", "Religions", "Area", "Population", "GDP", "Languages" }

			For Each fieldName As String In fieldNames
				Dim column As GridColumn = myGridView.Columns.AddField(fieldName)
				column.Visible = True
			Next fieldName
		End Sub

		Private Sub RegisterViewsInComboBox()
			comboView.Items.Add("Auto")
			For Each view As BaseView In gridControl1.ViewCollection
				comboView.Items.Add(view.ViewCaption)
			Next view
			comboViewTypeItem.EditValue = gridControl1.ViewCollection(0).ViewCaption
		End Sub

		Private Sub barComboItem_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboViewTypeItem.EditValueChanged
			Dim comboBox As ComboBoxEdit = TryCast(barManager.ActiveEditor, ComboBoxEdit)
			If comboBox Is Nothing Then
				Return
			End If
			If comboBox.EditValue.ToString() = "Auto" Then
				SetAutoView()
			Else
				Dim selectedView As BaseView = gridControl1.ViewCollection(comboBox.SelectedIndex - 1)
				gridControl1.MainView = selectedView
			End If
		End Sub

		Private Sub gridControl1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles gridControl1.Resize
			If comboViewTypeItem.EditValue.ToString() <> "Auto" Then
				Return
			End If
			SetAutoView()
		End Sub

		Private Sub SetAutoView()
			If gridControl1.Width < 700 Then
				gridControl1.MainView = layoutView1
			Else
				gridControl1.MainView = myGridView
			End If
		End Sub

		Private Sub gridControl1_DefaultViewChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridControl1.DefaultViewChanged
			checkShowFooter.Enabled = TypeOf gridControl1.MainView Is GridView
			If checkShowFooter.Enabled Then
				checkShowFooter.Checked = (TryCast(gridControl1.MainView, GridView)).OptionsView.ShowFooter
			Else
				checkShowFooter.Checked = False
			End If
		End Sub

		Private Sub checkShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles checkShowFooter.CheckedChanged
			If TypeOf gridControl1.MainView Is GridView Then
				TryCast(gridControl1.MainView, GridView).OptionsView.ShowFooter = checkShowFooter.Checked
			End If
		End Sub
	End Class
End Namespace