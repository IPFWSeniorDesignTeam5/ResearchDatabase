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
            // TODO: This line of code loads data into the 'researchDatabaseDataSet.Platform' table. You can move, or remove it, as needed.
            this.platformTableAdapter.Fill(this.researchDatabaseDataSet.Platform);
            // TODO: This line of code loads data into the 'researchDatabaseDataSet.ApplicationGenre' table. You can move, or remove it, as needed.
            this.applicationGenreTableAdapter.Fill(this.researchDatabaseDataSet.ApplicationGenre);

            this.developerTableAdapter.Fill(this.researchDatabaseDataSet.Developer);
                        
            this.applicationTableAdapter.Fill(this.researchDatabaseDataSet.Application);

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
        }

        private void NewApplicationClicked(object sender, EventArgs e)
        {
            NewApplication lk_new = new NewApplication();

            lk_new.ShowDialog();
        }
    }
}
