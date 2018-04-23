using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;


namespace DXWindowsApplication5
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            AddGridView();
            RegisterViewsInComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'countriesDBDataSet.Countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.countriesDBDataSet.Countries);
         }

        GridView myGridView;

        private void AddGridView()
        {
            myGridView = new GridView(gridControl1);
            myGridView.ViewCaption = "Table";


            string[] fieldNames = new string[] { "Country", "Capital", 
                "Currency", "Religions", "Area", "Population", "GDP", "Languages" };

            foreach (string fieldName in fieldNames) {
                GridColumn column = myGridView.Columns.AddField(fieldName);
                column.Visible = true;
            }
        }

        private void RegisterViewsInComboBox()
        {
            comboView.Items.Add("Auto");
            foreach (BaseView view in gridControl1.ViewCollection)
                comboView.Items.Add(view.ViewCaption);
            comboViewTypeItem.EditValue = gridControl1.ViewCollection[0].ViewCaption;
        }

        private void barComboItem_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = barManager.ActiveEditor as ComboBoxEdit;
            if (comboBox == null) 
                return;
            if (comboBox.EditValue.ToString() == "Auto")
                SetAutoView();
            else
            {
                BaseView selectedView = gridControl1.ViewCollection[comboBox.SelectedIndex - 1];
                gridControl1.MainView = selectedView;
            }
        }

        private void gridControl1_Resize(object sender, EventArgs e)
        {
            if (comboViewTypeItem.EditValue.ToString() != "Auto")
                return;
            SetAutoView();
        }

        private void SetAutoView()
        {
            if (gridControl1.Width < 700)
                gridControl1.MainView = layoutView1;
            else
                gridControl1.MainView = myGridView;
        }

        private void gridControl1_DefaultViewChanged(object sender, EventArgs e)
        {
            checkShowFooter.Enabled = gridControl1.MainView is GridView;
            if (checkShowFooter.Enabled)
                checkShowFooter.Checked = (gridControl1.MainView as GridView).OptionsView.ShowFooter;
            else
                checkShowFooter.Checked = false;
        }

        private void checkShowFooter_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridControl1.MainView is GridView)
                (gridControl1.MainView as GridView).OptionsView.ShowFooter = checkShowFooter.Checked;
        }
    }
}