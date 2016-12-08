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
    public partial class GraphControl : UserControl
    {
        public GraphControl()
        {
            InitializeComponent();
        }

        private void ReportSeries_changed(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            ResultsChart.Series[0].Name = combo.Text + "s";
            
            ResultsChart.Visible = false;
            ResultsChart.Series[1].Enabled = false;
            ResultsChart.Series[1].XValueMember = "";
            ResultsChart.Series[1].YValueMembers = "";

            switch (combo.Text)
            {
                case "Genre":
                    vW_GenresTableAdapter.Fill(researchDatabaseDataSet.VW_Genres);
                    ResultsChart.DataSource = vW_GenresBindingSource;
                    ResultsChart.Series[0].XValueMember = "Description";
                    ResultsChart.Series[0].YValueMembers = "Relations";
                    ResultsChart.DataBind();
                    ResultsChart.ChartAreas[0].AxisY.Title = "Use Count";
                    ResultsChart.ChartAreas[0].AxisX.Title = "Genre Description";
                    break;

                case "Mechanic":
                    vW_MechanicsTableAdapter.Fill(researchDatabaseDataSet.VW_Mechanics);
                    ResultsChart.DataSource = vW_MechanicsBindingSource;
                    ResultsChart.Series[0].XValueMember = "Description";
                    ResultsChart.Series[0].YValueMembers = "Relations";
                    ResultsChart.DataBind();
                    ResultsChart.ChartAreas[0].AxisY.Title = "Use Count";
                    ResultsChart.ChartAreas[0].AxisX.Title = "Mechanic Description";
                    break;
                case "Genre Pair":
                    vW_GenrePairsTableAdapter.Fill(researchDatabaseDataSet.VW_GenrePairs);
                    ResultsChart.DataSource = vW_GenrePairsBindingSource;
                    ResultsChart.Series[0].XValueMember = "Pair";
                    ResultsChart.Series[0].YValueMembers = "Relations";
                    ResultsChart.DataBind();
                    ResultsChart.ChartAreas[0].AxisY.Title = "Uses Together";
                    ResultsChart.ChartAreas[0].AxisX.Title = "Pair Description";
                    break;

                case "Mechanic Pair":
                    vW_MechanicPairTableAdapter.Fill(researchDatabaseDataSet.VW_MechanicPair);
                    ResultsChart.DataSource = vW_MechanicPairBindingSource;
                    ResultsChart.Series[0].XValueMember = "Pair";
                    ResultsChart.Series[0].YValueMembers = "Relations";
                    ResultsChart.DataBind();
                    ResultsChart.ChartAreas[0].AxisY.Title = "Uses Together";
                    ResultsChart.ChartAreas[0].AxisX.Title = "Pair Description";
                    break;
                case "Genre Review":
                    vW_GenreReviewTableAdapter.Fill(researchDatabaseDataSet.VW_GenreReview);
                    ResultsChart.DataSource = vW_GenreReviewBindingSource;
                    ResultsChart.Series[0].XValueMember = "Description";
                    ResultsChart.Series[0].YValueMembers = "ReviewTime";
                    ResultsChart.Series[1].Enabled = true;
                    ResultsChart.Series[1].XValueMember = "Description";
                    ResultsChart.Series[1].YValueMembers = "AverageRating";
                    ResultsChart.DataBind();
                    ResultsChart.ChartAreas[0].AxisY.Title = "Time Spent (m)";
                    ResultsChart.ChartAreas[0].AxisX.Title = "Genre Description";
                    ResultsChart.Series[1].Enabled = true;
                    break;
                case "Mechanic Review":
                    vW_MechanicReviewTableAdapter.Fill(researchDatabaseDataSet.VW_MechanicReview);
                    ResultsChart.DataSource = vW_MechanicReviewBindingSource;
                    ResultsChart.Series[1].Enabled = true;
                    ResultsChart.Series[1].XValueMember = "Description";
                    ResultsChart.Series[1].YValueMembers = "AverageRating";
                    ResultsChart.Series[0].XValueMember = "Description";
                    ResultsChart.Series[0].YValueMembers = "ReviewTime";
                    ResultsChart.DataBind();
                    ResultsChart.ChartAreas[0].AxisY.Title = "Time Spent (m)";
                    ResultsChart.ChartAreas[0].AxisX.Title = "Mechanic Description";
                    break;
            }
            
            ResultsChart.Visible = true;
        }

        private void ChartType_changed(object sender, EventArgs e)
        {
            switch (ChartTypeCombo.Text)
            {
                case "Bar":
                    ResultsChart.Series[0].ChartType = ResultsChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    ResultsChart.Series[0].MarkerSize = 1;
                    ResultsChart.ChartAreas[0].AxisX.IsReversed = true;
                    break;
                case "Point":
                    ResultsChart.Series[0].ChartType = ResultsChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    ResultsChart.Series[0].MarkerSize = 10;
                    ResultsChart.ChartAreas[0].AxisX.IsReversed = false;
                    break;
                case "Pie":
                    ResultsChart.Series[0].ChartType = ResultsChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    ResultsChart.Series[0].MarkerSize = 1;
                    ResultsChart.ChartAreas[0].AxisX.IsReversed = false;
                    break;
            }

        }

        private void Control_resized(object sender, EventArgs e)
        {
            Rectangle logoPos = new Rectangle((Bounds.Width / 2) - (LogoPicture.Bounds.Width / 2), (Bounds.Height / 2) - (LogoPicture.Bounds.Height / 2), LogoPicture.Bounds.Width, LogoPicture.Bounds.Height);
            LogoPicture.Bounds = logoPos;
        }
    }
}

