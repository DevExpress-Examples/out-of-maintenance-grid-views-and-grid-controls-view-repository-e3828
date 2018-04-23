Imports Microsoft.VisualBasic
Imports System
Namespace DXWindowsApplication5
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colCountry1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colOfficialName1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCapital1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colCurrency1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colLanguages1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colReligions1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colPopulation1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colGDP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colArea1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colBFlag = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.comboViewTypeItem = New DevExpress.XtraBars.BarEditItem()
			Me.comboView = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.checkShowFooter = New DevExpress.XtraBars.BarCheckItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.mFile = New DevExpress.XtraBars.BarSubItem()
			Me.iNew = New DevExpress.XtraBars.BarButtonItem()
			Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
			Me.iClose = New DevExpress.XtraBars.BarButtonItem()
			Me.iSave = New DevExpress.XtraBars.BarButtonItem()
			Me.iSaveAs = New DevExpress.XtraBars.BarButtonItem()
			Me.iExit = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.mHelp = New DevExpress.XtraBars.BarSubItem()
			Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colCountry = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colCountry = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colOfficialName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colOfficialName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colCurrency = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colCurrency = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colCapital = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colCapital = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colArea = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colArea = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colPopulation = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colPopulation = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colLanguages = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colLanguages = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colReligions = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colReligions = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colFlag = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colFlag = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.navbarImageListLarge = New System.Windows.Forms.ImageList(Me.components)
			Me.navbarImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.countriesDBDataSet = New DXWindowsApplication5.countriesDBDataSet()
			Me.countriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.countriesTableAdapter = New DXWindowsApplication5.countriesDBDataSetTableAdapters.CountriesTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCountry, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colOfficialName, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCapital, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colArea, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPopulation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colReligions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colFlag, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.countriesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.countriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.countriesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 29)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.MenuManager = Me.barManager
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(987, 554)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.layoutView1})
'			Me.gridControl1.DefaultViewChanged += New System.EventHandler(Me.gridControl1_DefaultViewChanged);
'			Me.gridControl1.Resize += New System.EventHandler(Me.gridControl1_Resize);
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand4, Me.gridBand2, Me.gridBand3})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colCountry1, Me.colOfficialName1, Me.colCurrency1, Me.colCapital1, Me.colBFlag, Me.colArea1, Me.colGDP, Me.colPopulation1, Me.colLanguages1, Me.colReligions1})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
			Me.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = True
			Me.advBandedGridView1.OptionsView.EnableAppearanceOddRow = True
			Me.advBandedGridView1.ViewCaption = "Compact Table"
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "General Information"
			Me.gridBand1.Columns.Add(Me.colCountry1)
			Me.gridBand1.Columns.Add(Me.colOfficialName1)
			Me.gridBand1.Columns.Add(Me.colCapital1)
			Me.gridBand1.MinWidth = 20
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 263
			' 
			' colCountry1
			' 
			Me.colCountry1.FieldName = "Country"
			Me.colCountry1.Name = "colCountry1"
			Me.colCountry1.Visible = True
			Me.colCountry1.Width = 263
			' 
			' colOfficialName1
			' 
			Me.colOfficialName1.FieldName = "OfficialName"
			Me.colOfficialName1.Name = "colOfficialName1"
			Me.colOfficialName1.RowIndex = 1
			Me.colOfficialName1.Visible = True
			Me.colOfficialName1.Width = 263
			' 
			' colCapital1
			' 
			Me.colCapital1.FieldName = "Capital"
			Me.colCapital1.Name = "colCapital1"
			Me.colCapital1.RowIndex = 2
			Me.colCapital1.Visible = True
			Me.colCapital1.Width = 263
			' 
			' gridBand4
			' 
			Me.gridBand4.Caption = "Additional Information"
			Me.gridBand4.Columns.Add(Me.colCurrency1)
			Me.gridBand4.Columns.Add(Me.colLanguages1)
			Me.gridBand4.Columns.Add(Me.colReligions1)
			Me.gridBand4.Name = "gridBand4"
			Me.gridBand4.Width = 323
			' 
			' colCurrency1
			' 
			Me.colCurrency1.FieldName = "Currency"
			Me.colCurrency1.Name = "colCurrency1"
			Me.colCurrency1.Visible = True
			Me.colCurrency1.Width = 323
			' 
			' colLanguages1
			' 
			Me.colLanguages1.FieldName = "Languages"
			Me.colLanguages1.Name = "colLanguages1"
			Me.colLanguages1.RowIndex = 1
			Me.colLanguages1.Visible = True
			Me.colLanguages1.Width = 323
			' 
			' colReligions1
			' 
			Me.colReligions1.FieldName = "Religions"
			Me.colReligions1.Name = "colReligions1"
			Me.colReligions1.RowIndex = 2
			Me.colReligions1.Visible = True
			Me.colReligions1.Width = 323
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Numbers"
			Me.gridBand2.Columns.Add(Me.colPopulation1)
			Me.gridBand2.Columns.Add(Me.colGDP)
			Me.gridBand2.Columns.Add(Me.colArea1)
			Me.gridBand2.MinWidth = 20
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 200
			' 
			' colPopulation1
			' 
			Me.colPopulation1.DisplayFormat.FormatString = "n0"
			Me.colPopulation1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPopulation1.FieldName = "Population"
			Me.colPopulation1.Name = "colPopulation1"
			Me.colPopulation1.Visible = True
			Me.colPopulation1.Width = 200
			' 
			' colGDP
			' 
			Me.colGDP.DisplayFormat.FormatString = "n"
			Me.colGDP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colGDP.FieldName = "GDP"
			Me.colGDP.Name = "colGDP"
			Me.colGDP.RowIndex = 1
			Me.colGDP.Visible = True
			Me.colGDP.Width = 200
			' 
			' colArea1
			' 
			Me.colArea1.DisplayFormat.FormatString = "n"
			Me.colArea1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colArea1.FieldName = "Area"
			Me.colArea1.Name = "colArea1"
			Me.colArea1.RowIndex = 2
			Me.colArea1.Visible = True
			Me.colArea1.Width = 200
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "Graphics"
			Me.gridBand3.Columns.Add(Me.colBFlag)
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.OptionsBand.AllowSize = False
			Me.gridBand3.OptionsBand.FixedWidth = True
			Me.gridBand3.Width = 183
			' 
			' colBFlag
			' 
			Me.colBFlag.AutoFillDown = True
			Me.colBFlag.Caption = "Flag"
			Me.colBFlag.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colBFlag.FieldName = "BFlag"
			Me.colBFlag.Name = "colBFlag"
			Me.colBFlag.Visible = True
			Me.colBFlag.Width = 183
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			' 
			' barManager
			' 
			Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.mFile, Me.barButtonItem2, Me.iOpen, Me.iClose, Me.iNew, Me.iSave, Me.iSaveAs, Me.iExit, Me.mHelp, Me.iAbout, Me.barCheckItem1, Me.comboViewTypeItem, Me.checkShowFooter})
			Me.barManager.MaxItemId = 22
			Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.comboView})
			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 3"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.comboViewTypeItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.checkShowFooter, True)})
			Me.bar1.Text = "Custom 3"
			' 
			' comboViewTypeItem
			' 
			Me.comboViewTypeItem.Caption = "View type"
			Me.comboViewTypeItem.Edit = Me.comboView
			Me.comboViewTypeItem.Id = 18
			Me.comboViewTypeItem.Name = "comboViewTypeItem"
			Me.comboViewTypeItem.Width = 121
'			Me.comboViewTypeItem.EditValueChanged += New System.EventHandler(Me.barComboItem_EditValueChanged);
			' 
			' comboView
			' 
			Me.comboView.AutoHeight = False
			Me.comboView.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboView.Name = "comboView"
			Me.comboView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' checkShowFooter
			' 
			Me.checkShowFooter.Caption = "Footer"
			Me.checkShowFooter.Id = 21
			Me.checkShowFooter.Name = "checkShowFooter"
'			Me.checkShowFooter.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.checkShowFooter_CheckedChanged);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(987, 29)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 583)
			Me.barDockControlBottom.Size = New System.Drawing.Size(987, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 554)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(987, 29)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 554)
			' 
			' mFile
			' 
			Me.mFile.Caption = "&File"
			Me.mFile.Id = 0
			Me.mFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iNew), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.iClose), New DevExpress.XtraBars.LinkPersistInfo(Me.iSave), New DevExpress.XtraBars.LinkPersistInfo(Me.iSaveAs), New DevExpress.XtraBars.LinkPersistInfo(Me.iExit)})
			Me.mFile.Name = "mFile"
			' 
			' iNew
			' 
			Me.iNew.Caption = "&New"
			Me.iNew.Id = 6
			Me.iNew.Name = "iNew"
			' 
			' iOpen
			' 
			Me.iOpen.Caption = "&Open"
			Me.iOpen.Id = 4
			Me.iOpen.Name = "iOpen"
			' 
			' iClose
			' 
			Me.iClose.Caption = "&Close"
			Me.iClose.Id = 5
			Me.iClose.Name = "iClose"
			' 
			' iSave
			' 
			Me.iSave.Caption = "&Save"
			Me.iSave.Id = 7
			Me.iSave.Name = "iSave"
			' 
			' iSaveAs
			' 
			Me.iSaveAs.Caption = "Save &As"
			Me.iSaveAs.Id = 8
			Me.iSaveAs.Name = "iSaveAs"
			' 
			' iExit
			' 
			Me.iExit.Caption = "E&xit"
			Me.iExit.Id = 9
			Me.iExit.Name = "iExit"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "Open"
			Me.barButtonItem2.Id = 2
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' mHelp
			' 
			Me.mHelp.Caption = "&Help"
			Me.mHelp.Id = 10
			Me.mHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.iAbout)})
			Me.mHelp.Name = "mHelp"
			' 
			' iAbout
			' 
			Me.iAbout.Caption = "&About"
			Me.iAbout.Id = 11
			Me.iAbout.Name = "iAbout"
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.Caption = "Grid View"
			Me.barCheckItem1.Id = 14
			Me.barCheckItem1.Name = "barCheckItem1"
			' 
			' layoutView1
			' 
			Me.layoutView1.CardCaptionFormat = "{2}"
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colCountry, Me.colOfficialName, Me.colCurrency, Me.colCapital, Me.colArea, Me.colPopulation, Me.colLanguages, Me.colReligions, Me.colFlag})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colCountry})
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate
			Me.layoutView1.OptionsView.ShowHeaderPanel = False
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
			Me.layoutView1.ViewCaption = "Cards"
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country"
			Me.colCountry.LayoutViewField = Me.layoutViewField_colCountry
			Me.colCountry.Name = "colCountry"
			' 
			' layoutViewField_colCountry
			' 
			Me.layoutViewField_colCountry.EditorPreferredWidth = 20
			Me.layoutViewField_colCountry.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colCountry.Name = "layoutViewField_colCountry"
			Me.layoutViewField_colCountry.Size = New System.Drawing.Size(203, 252)
			Me.layoutViewField_colCountry.TextSize = New System.Drawing.Size(67, 13)
			Me.layoutViewField_colCountry.TextToControlDistance = 5
			' 
			' colOfficialName
			' 
			Me.colOfficialName.FieldName = "OfficialName"
			Me.colOfficialName.LayoutViewField = Me.layoutViewField_colOfficialName
			Me.colOfficialName.Name = "colOfficialName"
			' 
			' layoutViewField_colOfficialName
			' 
			Me.layoutViewField_colOfficialName.EditorPreferredWidth = 127
			Me.layoutViewField_colOfficialName.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colOfficialName.Name = "layoutViewField_colOfficialName"
			Me.layoutViewField_colOfficialName.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colOfficialName.TextSize = New System.Drawing.Size(67, 13)
			Me.layoutViewField_colOfficialName.TextToControlDistance = 5
			' 
			' colCurrency
			' 
			Me.colCurrency.FieldName = "Currency"
			Me.colCurrency.LayoutViewField = Me.layoutViewField_colCurrency
			Me.colCurrency.Name = "colCurrency"
			' 
			' layoutViewField_colCurrency
			' 
			Me.layoutViewField_colCurrency.EditorPreferredWidth = 127
			Me.layoutViewField_colCurrency.Location = New System.Drawing.Point(0, 20)
			Me.layoutViewField_colCurrency.Name = "layoutViewField_colCurrency"
			Me.layoutViewField_colCurrency.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colCurrency.TextSize = New System.Drawing.Size(67, 13)
			Me.layoutViewField_colCurrency.TextToControlDistance = 5
			' 
			' colCapital
			' 
			Me.colCapital.FieldName = "Capital"
			Me.colCapital.LayoutViewField = Me.layoutViewField_colCapital
			Me.colCapital.Name = "colCapital"
			' 
			' layoutViewField_colCapital
			' 
			Me.layoutViewField_colCapital.EditorPreferredWidth = 127
			Me.layoutViewField_colCapital.Location = New System.Drawing.Point(0, 40)
			Me.layoutViewField_colCapital.Name = "layoutViewField_colCapital"
			Me.layoutViewField_colCapital.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colCapital.TextSize = New System.Drawing.Size(67, 13)
			Me.layoutViewField_colCapital.TextToControlDistance = 5
			' 
			' colArea
			' 
			Me.colArea.DisplayFormat.FormatString = "n"
			Me.colArea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colArea.FieldName = "Area"
			Me.colArea.LayoutViewField = Me.layoutViewField_colArea
			Me.colArea.Name = "colArea"
			' 
			' layoutViewField_colArea
			' 
			Me.layoutViewField_colArea.EditorPreferredWidth = 127
			Me.layoutViewField_colArea.Location = New System.Drawing.Point(0, 60)
			Me.layoutViewField_colArea.Name = "layoutViewField_colArea"
			Me.layoutViewField_colArea.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colArea.TextSize = New System.Drawing.Size(67, 13)
			Me.layoutViewField_colArea.TextToControlDistance = 5
			' 
			' colPopulation
			' 
			Me.colPopulation.DisplayFormat.FormatString = "n0"
			Me.colPopulation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPopulation.FieldName = "Population"
			Me.colPopulation.LayoutViewField = Me.layoutViewField_colPopulation
			Me.colPopulation.Name = "colPopulation"
			' 
			' layoutViewField_colPopulation
			' 
			Me.layoutViewField_colPopulation.EditorPreferredWidth = 127
			Me.layoutViewField_colPopulation.Location = New System.Drawing.Point(0, 80)
			Me.layoutViewField_colPopulation.Name = "layoutViewField_colPopulation"
			Me.layoutViewField_colPopulation.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colPopulation.TextSize = New System.Drawing.Size(67, 13)
			Me.layoutViewField_colPopulation.TextToControlDistance = 5
			' 
			' colLanguages
			' 
			Me.colLanguages.FieldName = "Languages"
			Me.colLanguages.LayoutViewField = Me.layoutViewField_colLanguages
			Me.colLanguages.Name = "colLanguages"
			' 
			' layoutViewField_colLanguages
			' 
			Me.layoutViewField_colLanguages.EditorPreferredWidth = 127
			Me.layoutViewField_colLanguages.Location = New System.Drawing.Point(0, 100)
			Me.layoutViewField_colLanguages.Name = "layoutViewField_colLanguages"
			Me.layoutViewField_colLanguages.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colLanguages.TextSize = New System.Drawing.Size(67, 13)
			Me.layoutViewField_colLanguages.TextToControlDistance = 5
			' 
			' colReligions
			' 
			Me.colReligions.FieldName = "Religions"
			Me.colReligions.LayoutViewField = Me.layoutViewField_colReligions
			Me.colReligions.Name = "colReligions"
			' 
			' layoutViewField_colReligions
			' 
			Me.layoutViewField_colReligions.EditorPreferredWidth = 127
			Me.layoutViewField_colReligions.Location = New System.Drawing.Point(0, 120)
			Me.layoutViewField_colReligions.Name = "layoutViewField_colReligions"
			Me.layoutViewField_colReligions.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colReligions.TextSize = New System.Drawing.Size(67, 13)
			Me.layoutViewField_colReligions.TextToControlDistance = 5
			' 
			' colFlag
			' 
			Me.colFlag.Caption = "Flag"
			Me.colFlag.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colFlag.FieldName = "BFlag"
			Me.colFlag.LayoutViewField = Me.layoutViewField_colFlag
			Me.colFlag.Name = "colFlag"
			Me.colFlag.OptionsColumn.ShowCaption = False
			' 
			' layoutViewField_colFlag
			' 
			Me.layoutViewField_colFlag.EditorPreferredWidth = 199
			Me.layoutViewField_colFlag.Location = New System.Drawing.Point(0, 140)
			Me.layoutViewField_colFlag.Name = "layoutViewField_colFlag"
			Me.layoutViewField_colFlag.Size = New System.Drawing.Size(203, 26)
			Me.layoutViewField_colFlag.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colFlag.TextToControlDistance = 0
			Me.layoutViewField_colFlag.TextVisible = False
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colOfficialName, Me.layoutViewField_colCurrency, Me.layoutViewField_colCapital, Me.layoutViewField_colArea, Me.layoutViewField_colPopulation, Me.layoutViewField_colLanguages, Me.layoutViewField_colReligions, Me.layoutViewField_colFlag})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
			Me.layoutViewCard1.Text = "TemplateCard"
			' 
			' navbarImageListLarge
			' 
			Me.navbarImageListLarge.ImageStream = (CType(resources.GetObject("navbarImageListLarge.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent
			Me.navbarImageListLarge.Images.SetKeyName(0, "Mail_16x16.png")
			Me.navbarImageListLarge.Images.SetKeyName(1, "Organizer_16x16.png")
			' 
			' navbarImageList
			' 
			Me.navbarImageList.ImageStream = (CType(resources.GetObject("navbarImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.navbarImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.navbarImageList.Images.SetKeyName(0, "Inbox_16x16.png")
			Me.navbarImageList.Images.SetKeyName(1, "Outbox_16x16.png")
			Me.navbarImageList.Images.SetKeyName(2, "Drafts_16x16.png")
			Me.navbarImageList.Images.SetKeyName(3, "Trash_16x16.png")
			Me.navbarImageList.Images.SetKeyName(4, "Calendar_16x16.png")
			Me.navbarImageList.Images.SetKeyName(5, "Tasks_16x16.png")
			' 
			' countriesDBDataSet
			' 
			Me.countriesDBDataSet.DataSetName = "countriesDBDataSet"
			Me.countriesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' countriesBindingSource
			' 
			Me.countriesBindingSource.DataMember = "Countries"
			Me.countriesBindingSource.DataSource = Me.countriesDBDataSet
			' 
			' countriesTableAdapter
			' 
			Me.countriesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(987, 583)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "XtraGrid Tutorial: Views"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCountry, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colOfficialName, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCurrency, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCapital, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colArea, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPopulation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colLanguages, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colReligions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colFlag, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.countriesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.countriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private mFile As DevExpress.XtraBars.BarSubItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private iOpen As DevExpress.XtraBars.BarButtonItem
		Private iClose As DevExpress.XtraBars.BarButtonItem
		Private iNew As DevExpress.XtraBars.BarButtonItem
		Private iSave As DevExpress.XtraBars.BarButtonItem
		Private iSaveAs As DevExpress.XtraBars.BarButtonItem
		Private iExit As DevExpress.XtraBars.BarButtonItem
		Private mHelp As DevExpress.XtraBars.BarSubItem
		Private iAbout As DevExpress.XtraBars.BarButtonItem
		Private navbarImageList As System.Windows.Forms.ImageList
		Private navbarImageListLarge As System.Windows.Forms.ImageList
		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
		Private WithEvents comboViewTypeItem As DevExpress.XtraBars.BarEditItem
		Private comboView As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private WithEvents checkShowFooter As DevExpress.XtraBars.BarCheckItem
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private colCountry As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCountry As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colOfficialName As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colOfficialName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colCurrency As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCurrency As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colCapital As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCapital As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colArea As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colArea As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colPopulation As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colPopulation As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colLanguages As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colLanguages As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colReligions As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colReligions As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colFlag As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colFlag As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colCountry1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colOfficialName1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCapital1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colCurrency1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colLanguages1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colReligions1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colPopulation1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colGDP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colArea1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colBFlag As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private countriesDBDataSet As countriesDBDataSet
		Private countriesBindingSource As System.Windows.Forms.BindingSource
		Private countriesTableAdapter As countriesDBDataSetTableAdapters.CountriesTableAdapter

	End Class
End Namespace
