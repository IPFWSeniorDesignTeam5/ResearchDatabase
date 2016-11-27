using System;
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
            bottomLineDataGridViewTextBoxColumn.DataGridView.Columns[0].Visible = false;
        }

        private void NewReview_clicked(object sender, EventArgs e)
        {
            NewReview lk_new = new NewReview();
            lk_new.Show();
            lk_new.Initialize(0, m_iAppId);
        }
    }
}
