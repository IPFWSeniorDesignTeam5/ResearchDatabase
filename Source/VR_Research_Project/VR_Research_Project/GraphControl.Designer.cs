namespace VR_Research_Project
{
    partial class GraphControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ComboBox ReportSeriesCombo;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ResultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.series1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartTypeCombo = new System.Windows.Forms.ComboBox();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.vW_GenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.vW_GenresTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.VW_GenresTableAdapter();
            this.vW_MechanicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_MechanicsTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.VW_MechanicsTableAdapter();
            this.vW_GenreReviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_GenreReviewTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.VW_GenreReviewTableAdapter();
            this.vW_GenrePairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_GenrePairsTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.VW_GenrePairsTableAdapter();
            this.vW_MechanicPairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_MechanicPairTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.VW_MechanicPairTableAdapter();
            this.vW_MechanicReviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_MechanicReviewTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.VW_MechanicReviewTableAdapter();
            ReportSeriesCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_GenresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_MechanicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_GenreReviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_GenrePairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_MechanicPairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_MechanicReviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportSeriesCombo
            // 
            ReportSeriesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ReportSeriesCombo.FormattingEnabled = true;
            ReportSeriesCombo.Items.AddRange(new object[] {
            "Genre",
            "Mechanic",
            "Genre Pair",
            "Mechanic Pair",
            "Genre Review",
            "Mechanic Review"});
            ReportSeriesCombo.Location = new System.Drawing.Point(152, 13);
            ReportSeriesCombo.Name = "ReportSeriesCombo";
            ReportSeriesCombo.Size = new System.Drawing.Size(283, 21);
            ReportSeriesCombo.TabIndex = 1;
            ReportSeriesCombo.SelectedIndexChanged += new System.EventHandler(this.ReportSeries_changed);
            // 
            // ResultsChart
            // 
            this.ResultsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.ResultsChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.ResultsChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 24;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Angle = -45;
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MinorTickMark.Interval = 1D;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Hack", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Use Count";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Hack", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.ResultsChart.ChartAreas.Add(chartArea1);
            this.ResultsChart.DataSource = this.vW_GenresBindingSource;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ResultsChart.Legends.Add(legend1);
            this.ResultsChart.Location = new System.Drawing.Point(14, 61);
            this.ResultsChart.Name = "ResultsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.EmptyPointStyle.MarkerSize = 1;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star10;
            series1.Name = "Series1";
            series1.ShadowOffset = 2;
            series1.XValueMember = "Description";
            series1.YValueMembers = "Relations";
            this.ResultsChart.Series.Add(series1);
            this.ResultsChart.Size = new System.Drawing.Size(980, 625);
            this.ResultsChart.TabIndex = 0;
            this.ResultsChart.Text = "Results";
            this.ResultsChart.Visible = false;
            // 
            // series1Label
            // 
            this.series1Label.AutoSize = true;
            this.series1Label.Location = new System.Drawing.Point(75, 16);
            this.series1Label.Name = "series1Label";
            this.series1Label.Size = new System.Drawing.Size(74, 13);
            this.series1Label.TabIndex = 2;
            this.series1Label.Text = "Report Series:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chart Type:";
            // 
            // ChartTypeCombo
            // 
            this.ChartTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartTypeCombo.FormattingEnabled = true;
            this.ChartTypeCombo.Items.AddRange(new object[] {
            "Bar",
            "Point",
            "Pie"});
            this.ChartTypeCombo.Location = new System.Drawing.Point(585, 13);
            this.ChartTypeCombo.Name = "ChartTypeCombo";
            this.ChartTypeCombo.Size = new System.Drawing.Size(167, 21);
            this.ChartTypeCombo.TabIndex = 3;
            this.ChartTypeCombo.SelectedIndexChanged += new System.EventHandler(this.ChartType_changed);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoPicture.BackgroundImage = global::VR_Research_Project.Properties.Resources.IPFW_Logo;
            this.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPicture.Location = new System.Drawing.Point(362, 240);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(317, 315);
            this.LogoPicture.TabIndex = 5;
            this.LogoPicture.TabStop = false;
            // 
            // vW_GenresBindingSource
            // 
            this.vW_GenresBindingSource.DataMember = "VW_Genres";
            this.vW_GenresBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // researchDatabaseDataSet
            // 
            this.researchDatabaseDataSet.DataSetName = "ResearchDatabaseDataSet";
            this.researchDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_GenresTableAdapter
            // 
            this.vW_GenresTableAdapter.ClearBeforeFill = true;
            // 
            // vW_MechanicsBindingSource
            // 
            this.vW_MechanicsBindingSource.DataMember = "VW_Mechanics";
            this.vW_MechanicsBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // vW_MechanicsTableAdapter
            // 
            this.vW_MechanicsTableAdapter.ClearBeforeFill = true;
            // 
            // vW_GenreReviewBindingSource
            // 
            this.vW_GenreReviewBindingSource.DataMember = "VW_GenreReview";
            this.vW_GenreReviewBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // vW_GenreReviewTableAdapter
            // 
            this.vW_GenreReviewTableAdapter.ClearBeforeFill = true;
            // 
            // vW_GenrePairsBindingSource
            // 
            this.vW_GenrePairsBindingSource.DataMember = "VW_GenrePairs";
            this.vW_GenrePairsBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // vW_GenrePairsTableAdapter
            // 
            this.vW_GenrePairsTableAdapter.ClearBeforeFill = true;
            // 
            // vW_MechanicPairBindingSource
            // 
            this.vW_MechanicPairBindingSource.DataMember = "VW_MechanicPair";
            this.vW_MechanicPairBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // vW_MechanicPairTableAdapter
            // 
            this.vW_MechanicPairTableAdapter.ClearBeforeFill = true;
            // 
            // vW_MechanicReviewBindingSource
            // 
            this.vW_MechanicReviewBindingSource.DataMember = "VW_MechanicReview";
            this.vW_MechanicReviewBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // vW_MechanicReviewTableAdapter
            // 
            this.vW_MechanicReviewTableAdapter.ClearBeforeFill = true;
            // 
            // GraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartTypeCombo);
            this.Controls.Add(this.series1Label);
            this.Controls.Add(ReportSeriesCombo);
            this.Controls.Add(this.ResultsChart);
            this.Controls.Add(this.LogoPicture);
            this.Name = "GraphControl";
            this.Size = new System.Drawing.Size(1007, 700);
            this.Resize += new System.EventHandler(this.Control_resized);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_GenresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_MechanicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_GenreReviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_GenrePairsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_MechanicPairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vW_MechanicReviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ResultsChart;
        private ResearchDatabaseDataSet researchDatabaseDataSet;
        private System.Windows.Forms.BindingSource vW_GenresBindingSource;
        private System.Windows.Forms.Label series1Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChartTypeCombo;
        private ResearchDatabaseDataSetTableAdapters.VW_GenresTableAdapter vW_GenresTableAdapter;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.BindingSource vW_MechanicsBindingSource;
        private ResearchDatabaseDataSetTableAdapters.VW_MechanicsTableAdapter vW_MechanicsTableAdapter;
        private System.Windows.Forms.BindingSource vW_GenreReviewBindingSource;
        private ResearchDatabaseDataSetTableAdapters.VW_GenreReviewTableAdapter vW_GenreReviewTableAdapter;
        private System.Windows.Forms.BindingSource vW_GenrePairsBindingSource;
        private ResearchDatabaseDataSetTableAdapters.VW_GenrePairsTableAdapter vW_GenrePairsTableAdapter;
        private System.Windows.Forms.BindingSource vW_MechanicPairBindingSource;
        private ResearchDatabaseDataSetTableAdapters.VW_MechanicPairTableAdapter vW_MechanicPairTableAdapter;
        private System.Windows.Forms.BindingSource vW_MechanicReviewBindingSource;
        private ResearchDatabaseDataSetTableAdapters.VW_MechanicReviewTableAdapter vW_MechanicReviewTableAdapter;
    }
}
