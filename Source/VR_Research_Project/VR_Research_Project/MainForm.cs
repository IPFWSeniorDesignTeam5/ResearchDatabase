using System;
using System.Drawing;
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
            SaveCurrentData();

            NewApplication lk_new = new NewApplication();

            lk_new.ShowDialog(this);

            RefreshData();

            if( lk_new.NewAppId != 0 )
            {
                listBox_Applications.SelectedIndex = listBox_Applications.FindStringExact(lk_new.NewAppName);
            }
        }

        private bool SaveCurrentData()
        {
            try
            {
                BindingContext[researchDatabaseDataSet, "Application"].EndCurrentEdit();
                tableAdapterManager.UpdateAll(researchDatabaseDataSet);
                researchDatabaseDataSet.AcceptChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Failed to update data. " + ex.Message, "Update Error");
            }

            return false;
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SaveCurrentData())
               if( MessageBox.Show( "Quit without saving?", "Closing", MessageBoxButtons.YesNo) == DialogResult.No )
                    e.Cancel = true;
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
