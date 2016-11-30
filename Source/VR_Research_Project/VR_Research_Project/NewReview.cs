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
    public partial class NewReview : Form
    {
        private int m_iReviewId = 0;
        private int m_iAppId = 0;

        public NewReview()
        {
            InitializeComponent();
        }

        public void Initialize(int reviewId, int applicationId)
        {
            m_iReviewId = reviewId;
            m_iAppId = applicationId;

            if (m_iReviewId == 0)
            {
                Text = "New Review";
                reviewBindingSource.AddNew();
                return;
            }
            else
                Text = "Review Details";

            reviewTableAdapter.FillByReviewId(researchDatabaseDataSet.Review, reviewId);
            appProTableAdapter.FillByReviewId(researchDatabaseDataSet.AppPro, reviewId);
            appConTableAdapter.FillByReviewId(researchDatabaseDataSet.AppCon, reviewId);
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void OKClicked(object sender, EventArgs e)
        {
            if (!Validate()) return;

            try
            {
                reviewBindingSource.EndEdit();
                appProBindingSource.EndEdit();
                appConBindingSource.EndEdit();

                reviewTableAdapter.Update(researchDatabaseDataSet);
                
                if (m_iReviewId == 0)
                {
                    m_iReviewId = ((ResearchDatabaseDataSet.ReviewRow)((DataRowView)reviewBindingSource.Current).Row).Id;
                    applicationReviewTableAdapter.Insert(m_iAppId, m_iReviewId);
                    applicationReviewTableAdapter.Update(researchDatabaseDataSet);
                }

                appProTableAdapter.Update(researchDatabaseDataSet);
                appConTableAdapter.Update(researchDatabaseDataSet);

                reviewProTableAdapter.DeleteByReview(m_iReviewId);
                reviewProTableAdapter.Update(researchDatabaseDataSet);

                reviewConTableAdapter.DeleteByReview(m_iReviewId);
                reviewConTableAdapter.Update(researchDatabaseDataSet);

                foreach (DataRowView item in appProBindingSource.List)
                {
                    ResearchDatabaseDataSet.AppProRow lk_row = (ResearchDatabaseDataSet.AppProRow)item.Row;
                    reviewProTableAdapter.Insert(m_iReviewId, lk_row.Id);
                }

                reviewProTableAdapter.Update(researchDatabaseDataSet);

                foreach (DataRowView item in appConBindingSource.List)
                {
                    ResearchDatabaseDataSet.AppConRow lk_row = (ResearchDatabaseDataSet.AppConRow)item.Row;
                    reviewConTableAdapter.Insert(m_iReviewId, lk_row.Id);
                }

                reviewConTableAdapter.Update(researchDatabaseDataSet);

                tableAdapterManager.UpdateAll(researchDatabaseDataSet);

                appProBindingSource.DataMember = null;
                appProBindingSource.DataSource = null;
                appProBindingSource.ResetBindings(true);

                appConBindingSource.DataMember = null;
                appConBindingSource.DataSource = null;
                appConBindingSource.ResetBindings(true);

                Close();

            } catch( Exception ex )
            {
                MessageBox.Show("Error updating. " + ex.Message, "Failed to Update");
            }
        }

        private void reviewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            OKClicked(sender, e);
        }

        private void NewReview_Load(object sender, EventArgs e)
        {

        }
    }
}
