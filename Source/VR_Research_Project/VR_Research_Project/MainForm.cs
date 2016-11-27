using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Research_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            platformTableAdapter.Fill(researchDatabaseDataSet.Platform);

            applicationGenreTableAdapter.Fill(researchDatabaseDataSet.ApplicationGenre);

            developerTableAdapter.Fill(researchDatabaseDataSet.Developer);

            applicationTableAdapter.Fill(researchDatabaseDataSet.Application);

            if (listBox_Applications.Items.Count > 0)
            {
                listBox_Applications.SelectedItem = listBox_Applications.Items[0];
                ApplicationSelected(listBox_Applications, new EventArgs());
            }
        }

        private void ApplicationSelected(object sender, EventArgs e)
        {
            if (null == listBox_Applications.SelectedValue) return;

            int applicationId = (int)listBox_Applications.SelectedValue;

            GenresControl.SelectApplication(applicationId, GenresAndMechanics.GenreAndMechanicsType.GenreType);
            MechanicsControl.SelectApplication(applicationId, GenresAndMechanics.GenreAndMechanicsType.MechanicsType);
            AppReviews.SelectApplication(applicationId);

            DeleteApplication.Enabled = true;
        }

        private void NewApplicationClicked(object sender, EventArgs e)
        {
            NewApplication lk_new = new NewApplication();

            lk_new.ShowDialog(this);

            RefreshData();
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                BindingContext[researchDatabaseDataSet, "Application"].EndCurrentEdit();
                tableAdapterManager.UpdateAll(researchDatabaseDataSet);
                researchDatabaseDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error", "Failed to update data. " + ex.Message);
                e.Cancel = true;
            }
        }

        private void ValidateGeneralTab(object sender, EventArgs e)
        {

        }

        private void DeleteApplication_clicked(object sender, EventArgs e)
        {
            DialogResult lk_result = MessageBox.Show("Delete the selected application and all related data?", "Are you sure?", MessageBoxButtons.YesNo);

            if (lk_result == DialogResult.Yes)
            {
                applicationTableAdapter.DeleteById((int)listBox_Applications.SelectedValue);
                applicationTableAdapter.Update(researchDatabaseDataSet);
                RefreshData();
                DeleteApplication.Enabled = false;
            }
        }

        private void ToolbarButton_clicked( object sender, EventArgs e )
        {
            foreach( ToolStripButton button in MainToolStrip.Items )
            {
                if (button.Name != ((ToolStripButton)sender).Name)
                {
                    button.Checked = false;
                    button.BackColor = SystemColors.Control;
                }
            }
            
            switch (((ToolStripButton)sender).Name)
            {
                case "ToolstripApplications_button":
                    ShowView("Applications");
                    break;

                case "ToolstripReporting_button":
                    ShowView("Genres/Mechanics");
                    break;

                default: break;
            }
        }

        private void ShowView( string as_view )
        {

        }
    }
}
