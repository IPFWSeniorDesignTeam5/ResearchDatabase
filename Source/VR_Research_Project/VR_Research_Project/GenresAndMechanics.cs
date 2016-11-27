using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Research_Project
{
    public partial class GenresAndMechanics : UserControl
    {
        private int ApplicationId;

        private GenreAndMechanicsType m_kType;

        public GenresAndMechanics()
        {
            InitializeComponent();
        }

        public enum GenreAndMechanicsType
        {
            GenreType = 1,
            MechanicsType 
        }

        public void SelectApplication( int applicationId, GenreAndMechanicsType objectType )
        {
            ApplicationId = applicationId;

            if (objectType == GenreAndMechanicsType.GenreType)
            {
                MainGridView.DataSource = GenreBindingSource;
                newLabel.Text = "Add Genre:";
            }
            else
            {
                MainGridView.DataSource = MechanicBindingSource;
                newLabel.Text = "Add Mechanic:";
            }

            AddButton.Enabled = true;
            m_kType = objectType;

            RefreshData();
        }

        private void RefreshData()
        {
            if( m_kType == GenreAndMechanicsType.GenreType )
            {
                GenreAdapter.FillByApplication(researchDatabaseDataSet.ApplicationGenreRelation, ApplicationId);
            } else
            {
                MechanicAdapter.FillByApplication(researchDatabaseDataSet.ApplicationMechanicRelation, ApplicationId);
            }
        }

        private void ValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Selected Changed
            {
                if (m_kType == GenreAndMechanicsType.GenreType)
                {
                    ResearchDatabaseDataSet.ApplicationGenreRelationRow boundItem = (ResearchDatabaseDataSet.ApplicationGenreRelationRow)((DataRowView)MainGridView.Rows[e.RowIndex].DataBoundItem).Row;
                    ResearchDatabaseDataSet.ApplicationGenreDataTable lk_tab = new ResearchDatabaseDataSet.ApplicationGenreDataTable();
                    ResearchDatabaseDataSetTableAdapters.ApplicationGenreTableAdapter lk_adapt = new ResearchDatabaseDataSetTableAdapters.ApplicationGenreTableAdapter();
                    lk_adapt.Fill(lk_tab);

                    if (boundItem.Selected == 1)
                        lk_adapt.Insert(ApplicationId, boundItem.GenreId);
                    else
                        lk_adapt.Delete(ApplicationId, boundItem.GenreId);

                    lk_tab.AcceptChanges();

                    lk_adapt.Update(researchDatabaseDataSet);
                }
                else
                {
                    ResearchDatabaseDataSet.ApplicationMechanicRelationRow boundItem = (ResearchDatabaseDataSet.ApplicationMechanicRelationRow)((DataRowView)MainGridView.Rows[e.RowIndex].DataBoundItem).Row;
                    ResearchDatabaseDataSet.ApplicationMechanicDataTable lk_tab = new ResearchDatabaseDataSet.ApplicationMechanicDataTable();
                    ResearchDatabaseDataSetTableAdapters.ApplicationMechanicTableAdapter lk_adapt = new ResearchDatabaseDataSetTableAdapters.ApplicationMechanicTableAdapter();
                    lk_adapt.Fill(lk_tab);

                    if (boundItem.Selected == 1)
                        lk_adapt.Insert(ApplicationId, boundItem.Id);
                    else
                        lk_adapt.Delete(ApplicationId, boundItem.Id);
                    
                    lk_adapt.Update(researchDatabaseDataSet);
                }
                
                RefreshData();
            }
        }

        private void AddButton_clicked(object sender, EventArgs e)
        {
            NewGenreMechanic lk_new = new NewGenreMechanic();
            lk_new.Initialize(m_kType, researchDatabaseDataSet);
            lk_new.ShowDialog();
            RefreshData();
        }
    }
}
