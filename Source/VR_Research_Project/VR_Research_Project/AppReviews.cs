using System;
using System.Data;
using System.Windows.Forms;

namespace VR_Research_Project
{
    public partial class AppReviews : UserControl
    {
        int m_iAppId = 0;

        public AppReviews()
        {
            InitializeComponent();
        }

        public void SelectApplication( int appId )
        {
            m_iAppId = appId;
            AddReview_button.Enabled = true;
            reviewTableAdapter.FillByAppId(researchDatabaseDataSet.Review, appId);
            ratingDataGridViewTextBoxColumn.DataGridView.Columns[0].Visible = false;
        }

        private void NewReview_clicked(object sender, EventArgs e)
        {
            ShowReviewDetails(0);
        }

        private void GridViewCell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 4)
            {
                int li_id = ((ResearchDatabaseDataSet.ReviewRow)((DataRowView)reviewBindingSource.Current).Row).Id;

                ShowReviewDetails(li_id);
            }
        }

        private void ShowReviewDetails( int reviewId )
        {
            NewReview lk_new = new NewReview();
            lk_new.Initialize(reviewId, m_iAppId);
            lk_new.ShowDialog();
            SelectApplication(m_iAppId);
        }
    }
}
