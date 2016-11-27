namespace VR_Research_Project
{
    partial class AppReviews
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
            System.Windows.Forms.DataGridView reviewGridView;
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottomLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.reviewTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ReviewTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddReview_button = new System.Windows.Forms.Button();
            reviewGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(reviewGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewGridView
            // 
            reviewGridView.AllowUserToAddRows = false;
            reviewGridView.AllowUserToDeleteRows = false;
            reviewGridView.AutoGenerateColumns = false;
            reviewGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            reviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reviewGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.reviewerDataGridViewTextBoxColumn,
            this.timeSpentDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.bottomLineDataGridViewTextBoxColumn});
            reviewGridView.DataSource = this.reviewBindingSource;
            reviewGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            reviewGridView.Location = new System.Drawing.Point(0, 0);
            reviewGridView.Name = "reviewGridView";
            reviewGridView.ReadOnly = true;
            reviewGridView.Size = new System.Drawing.Size(437, 468);
            reviewGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // reviewerDataGridViewTextBoxColumn
            // 
            this.reviewerDataGridViewTextBoxColumn.DataPropertyName = "Reviewer";
            this.reviewerDataGridViewTextBoxColumn.HeaderText = "Reviewer";
            this.reviewerDataGridViewTextBoxColumn.Name = "reviewerDataGridViewTextBoxColumn";
            this.reviewerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeSpentDataGridViewTextBoxColumn
            // 
            this.timeSpentDataGridViewTextBoxColumn.DataPropertyName = "TimeSpent";
            this.timeSpentDataGridViewTextBoxColumn.HeaderText = "TimeSpent";
            this.timeSpentDataGridViewTextBoxColumn.Name = "timeSpentDataGridViewTextBoxColumn";
            this.timeSpentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bottomLineDataGridViewTextBoxColumn
            // 
            this.bottomLineDataGridViewTextBoxColumn.DataPropertyName = "BottomLine";
            this.bottomLineDataGridViewTextBoxColumn.HeaderText = "BottomLine";
            this.bottomLineDataGridViewTextBoxColumn.Name = "bottomLineDataGridViewTextBoxColumn";
            this.bottomLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reviewBindingSource
            // 
            this.reviewBindingSource.DataMember = "Review";
            this.reviewBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // researchDatabaseDataSet
            // 
            this.researchDatabaseDataSet.DataSetName = "ResearchDatabaseDataSet";
            this.researchDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewTableAdapter
            // 
            this.reviewTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddReview_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 33);
            this.panel1.TabIndex = 1;
            // 
            // AddReview_button
            // 
            this.AddReview_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddReview_button.Enabled = false;
            this.AddReview_button.Location = new System.Drawing.Point(333, 6);
            this.AddReview_button.Name = "AddReview_button";
            this.AddReview_button.Size = new System.Drawing.Size(98, 23);
            this.AddReview_button.TabIndex = 0;
            this.AddReview_button.Text = "New Review...";
            this.AddReview_button.UseVisualStyleBackColor = true;
            this.AddReview_button.Click += new System.EventHandler(this.NewReview_clicked);
            // 
            // AppReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(reviewGridView);
            this.Controls.Add(this.panel1);
            this.Name = "AppReviews";
            this.Size = new System.Drawing.Size(437, 501);
            ((System.ComponentModel.ISupportInitialize)(reviewGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource reviewBindingSource;
        private ResearchDatabaseDataSet researchDatabaseDataSet;
        private ResearchDatabaseDataSetTableAdapters.ReviewTableAdapter reviewTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddReview_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bottomLineDataGridViewTextBoxColumn;
    }
}
