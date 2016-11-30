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
    public partial class NewApplication : Form
    {
        private int m_iNewAppId = 0;

        public int NewAppId
        {
            get { return m_iNewAppId; }
        }

        public NewApplication()
        {
            InitializeComponent();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void NewApplication_Load(object sender, EventArgs e)
        {
            developerTableAdapter.Fill(researchDatabaseDataSet.Developer);
            NameTextbox.Focus();
        }

        private void OKClicked(object sender, EventArgs e)
        {
            ErrorText.Text = "";

            if (NameTextbox.Text == "")
            {
                ErrorText.Text = "Application name required.";
                return;
            }

            if (DeveloperCombobox.Text == "")
            {
                ErrorText.Text = "Developer required.";
                return;
            }

            string ls_newAppName = NameTextbox.Text;
            string ls_developerName = DeveloperCombobox.Text;

            if (researchDatabaseDataSet.Application.Where(x => x.Name.ToUpper() == ls_newAppName.ToUpper()).Count() > 0)
            {
                ErrorText.Text = "Application with that name already exists.";
                return;
            }
            
            bool newDev = true;
            int newDeveloperId = 0;

            foreach ( DataRowView item in DeveloperCombobox.Items )
            {
                if (DeveloperCombobox.Text == item.Row["Name"].ToString())
                {
                    newDeveloperId = (int)DeveloperCombobox.SelectedValue;
                    newDev = false;
                }
            }
            
            if ( newDev )
            {
                BindingContext[researchDatabaseDataSet, "Developer"].EndCurrentEdit();

                developerTableAdapter.Insert(ls_developerName);
                developerTableAdapter.Update(researchDatabaseDataSet.Developer);
                developerTableAdapter.Fill(researchDatabaseDataSet.Developer);

                EnumerableRowCollection<ResearchDatabaseDataSet.DeveloperRow> lk_rows = researchDatabaseDataSet.Developer.Where(x => x.Name == ls_developerName);

                if (lk_rows.Count() > 0)
                    newDeveloperId = lk_rows.First().Id;
            }

            ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter lk_appAdapter = new ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter();
            lk_appAdapter.Insert(ls_newAppName, newDeveloperId, releaseDate.Value, 1, "", "");
            lk_appAdapter.Update(researchDatabaseDataSet);

            if (researchDatabaseDataSet.Application.Where(x => x.Name.ToUpper() == ls_newAppName.ToUpper()).Count() > 0)
            {
                ErrorText.Text = "Application with that name already exists.";
                return;
            }

            Close();
        }
    }
}
