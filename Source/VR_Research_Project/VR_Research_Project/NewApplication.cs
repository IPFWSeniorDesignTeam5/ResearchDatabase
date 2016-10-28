﻿using System;
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
            this.developerTableAdapter.Fill(researchDatabaseDataSet.Developer);

            foreach (var row in researchDatabaseDataSet.Developer)
            {
                DeveloperCombobox.Items.Add(row.Name);
            }
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

            if (researchDatabaseDataSet.Application.Where(x => x.Name.ToUpper() == ls_newAppName.ToUpper()).Count() > 0)
            {
                ErrorText.Text = "Application with that name already exists.";
                return;
            }
            
            bool newDev = true;
            int newDeveloperId = 0;

            foreach ( var item in DeveloperCombobox.Items )
            {
                if (DeveloperCombobox.Text == item.ToString())
                {
                    newDeveloperId = researchDatabaseDataSet.Developer.Where(x => x.Name == DeveloperCombobox.Text).First().Id;
                    newDev = false;
                }
            }
            
            if ( newDev )
            {
                developerTableAdapter.Insert(DeveloperCombobox.Text);
                developerTableAdapter.Update(researchDatabaseDataSet.Developer);
                researchDatabaseDataSet.AcceptChanges();
                
                EnumerableRowCollection<ResearchDatabaseDataSet.DeveloperRow> lk_rows = researchDatabaseDataSet.Developer.Where(x => x.Name == DeveloperCombobox.Text);

                if (lk_rows.Count() > 0)
                    newDeveloperId = lk_rows.First().Id;
            }

            ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter lk_appAdapter = new ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter();
            lk_appAdapter.Insert(ls_newAppName, newDeveloperId, null, 1, "", "");
            lk_appAdapter.Update(researchDatabaseDataSet);

            Close();
        } 
    }
}
