namespace VR_Research_Project
{
    partial class NewReview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label reviewerLabel;
            System.Windows.Forms.Label timeSpentLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label bottomLineLabel;
            System.Windows.Forms.Label reviewDateLabel;
            System.Windows.Forms.Label label3;
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.reviewerTextBox = new System.Windows.Forms.TextBox();
            this.timeSpentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ratingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bottomLineTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appProDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appProBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ReviewTableAdapter();
            this.tableAdapterManager = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager();
            this.applicationReviewTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationReviewTableAdapter();
            this.appProTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.AppProTableAdapter();
            this.reviewConTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ReviewConTableAdapter();
            this.reviewProTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ReviewProTableAdapter();
            this.reviewDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appConBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appConTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.AppConTableAdapter();
            this.appConDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            reviewerLabel = new System.Windows.Forms.Label();
            timeSpentLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            bottomLineLabel = new System.Windows.Forms.Label();
            reviewDateLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appProDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appProBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appConBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appConDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewerLabel
            // 
            reviewerLabel.AutoSize = true;
            reviewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reviewerLabel.Location = new System.Drawing.Point(29, 39);
            reviewerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            reviewerLabel.Name = "reviewerLabel";
            reviewerLabel.Size = new System.Drawing.Size(125, 17);
            reviewerLabel.TabIndex = 7;
            reviewerLabel.Text = "Reviewer Name:";
            // 
            // timeSpentLabel
            // 
            timeSpentLabel.AutoSize = true;
            timeSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeSpentLabel.Location = new System.Drawing.Point(59, 149);
            timeSpentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            timeSpentLabel.Name = "timeSpentLabel";
            timeSpentLabel.Size = new System.Drawing.Size(95, 17);
            timeSpentLabel.TabIndex = 99;
            timeSpentLabel.Text = "Time Spent:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ratingLabel.Location = new System.Drawing.Point(370, 149);
            ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(111, 17);
            ratingLabel.TabIndex = 99;
            ratingLabel.Text = "Rating ( 1-5 ):";
            // 
            // bottomLineLabel
            // 
            bottomLineLabel.AutoSize = true;
            bottomLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bottomLineLabel.Location = new System.Drawing.Point(43, 204);
            bottomLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bottomLineLabel.Name = "bottomLineLabel";
            bottomLineLabel.Size = new System.Drawing.Size(111, 17);
            bottomLineLabel.TabIndex = 99;
            bottomLineLabel.Text = "\"Bottom Line\":";
            // 
            // reviewDateLabel
            // 
            reviewDateLabel.AutoSize = true;
            reviewDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reviewDateLabel.Location = new System.Drawing.Point(51, 95);
            reviewDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            reviewDateLabel.Name = "reviewDateLabel";
            reviewDateLabel.Size = new System.Drawing.Size(103, 17);
            reviewDateLabel.TabIndex = 99;
            reviewDateLabel.Text = "Review Date:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(365, 658);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(115, 28);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKClicked);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(488, 658);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 28);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelClicked);
            // 
            // ErrorText
            // 
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(31, 622);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(561, 20);
            this.ErrorText.TabIndex = 6;
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // reviewerTextBox
            // 
            this.reviewerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "Reviewer", true));
            this.reviewerTextBox.Location = new System.Drawing.Point(162, 37);
            this.reviewerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reviewerTextBox.Name = "reviewerTextBox";
            this.reviewerTextBox.Size = new System.Drawing.Size(269, 22);
            this.reviewerTextBox.TabIndex = 0;
            // 
            // timeSpentNumericUpDown
            // 
            this.timeSpentNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reviewBindingSource, "TimeSpent", true));
            this.timeSpentNumericUpDown.Location = new System.Drawing.Point(162, 148);
            this.timeSpentNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeSpentNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeSpentNumericUpDown.Name = "timeSpentNumericUpDown";
            this.timeSpentNumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.timeSpentNumericUpDown.TabIndex = 2;
            // 
            // ratingNumericUpDown
            // 
            this.ratingNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reviewBindingSource, "Rating", true));
            this.ratingNumericUpDown.Location = new System.Drawing.Point(491, 148);
            this.ratingNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ratingNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratingNumericUpDown.Name = "ratingNumericUpDown";
            this.ratingNumericUpDown.Size = new System.Drawing.Size(56, 22);
            this.ratingNumericUpDown.TabIndex = 3;
            this.ratingNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bottomLineTextBox
            // 
            this.bottomLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "BottomLine", true));
            this.bottomLineTextBox.Location = new System.Drawing.Point(162, 199);
            this.bottomLineTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bottomLineTextBox.MaxLength = 500;
            this.bottomLineTextBox.Multiline = true;
            this.bottomLineTextBox.Name = "bottomLineTextBox";
            this.bottomLineTextBox.Size = new System.Drawing.Size(384, 116);
            this.bottomLineTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Pros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Cons:";
            // 
            // appProDataGridView
            // 
            this.appProDataGridView.AutoGenerateColumns = false;
            this.appProDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appProDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appProDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.appProDataGridView.DataSource = this.appProBindingSource;
            this.appProDataGridView.Location = new System.Drawing.Point(24, 353);
            this.appProDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appProDataGridView.Name = "appProDataGridView";
            this.appProDataGridView.Size = new System.Drawing.Size(568, 118);
            this.appProDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // appProBindingSource
            // 
            this.appProBindingSource.DataMember = "AppPro";
            this.appProBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // reviewTableAdapter
            // 
            this.reviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppConTableAdapter = null;
            this.tableAdapterManager.ApplicationGenreTableAdapter = null;
            this.tableAdapterManager.ApplicationMechanicTableAdapter = null;
            this.tableAdapterManager.ApplicationReviewTableAdapter = this.applicationReviewTableAdapter;
            this.tableAdapterManager.ApplicationTableAdapter = null;
            this.tableAdapterManager.AppProTableAdapter = this.appProTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeveloperTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MechanicTableAdapter = null;
            this.tableAdapterManager.PlatformTableAdapter = null;
            this.tableAdapterManager.ReviewConTableAdapter = this.reviewConTableAdapter;
            this.tableAdapterManager.ReviewProTableAdapter = this.reviewProTableAdapter;
            this.tableAdapterManager.ReviewTableAdapter = this.reviewTableAdapter;
            this.tableAdapterManager.UpdateOrder = VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // applicationReviewTableAdapter
            // 
            this.applicationReviewTableAdapter.ClearBeforeFill = true;
            // 
            // appProTableAdapter
            // 
            this.appProTableAdapter.ClearBeforeFill = true;
            // 
            // reviewConTableAdapter
            // 
            this.reviewConTableAdapter.ClearBeforeFill = true;
            // 
            // reviewProTableAdapter
            // 
            this.reviewProTableAdapter.ClearBeforeFill = true;
            // 
            // reviewDateDateTimePicker
            // 
            this.reviewDateDateTimePicker.CustomFormat = "";
            this.reviewDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reviewBindingSource, "ReviewDate", true));
            this.reviewDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reviewDateDateTimePicker.Location = new System.Drawing.Point(162, 94);
            this.reviewDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reviewDateDateTimePicker.Name = "reviewDateDateTimePicker";
            this.reviewDateDateTimePicker.Size = new System.Drawing.Size(139, 22);
            this.reviewDateDateTimePicker.TabIndex = 1;
            // 
            // appConBindingSource
            // 
            this.appConBindingSource.DataMember = "AppCon";
            this.appConBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // appConTableAdapter
            // 
            this.appConTableAdapter.ClearBeforeFill = true;
            // 
            // appConDataGridView
            // 
            this.appConDataGridView.AutoGenerateColumns = false;
            this.appConDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appConDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appConDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.appConDataGridView.DataSource = this.appConBindingSource;
            this.appConDataGridView.Location = new System.Drawing.Point(24, 498);
            this.appConDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appConDataGridView.Name = "appConDataGridView";
            this.appConDataGridView.Size = new System.Drawing.Size(568, 126);
            this.appConDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(256, 150);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 17);
            label3.TabIndex = 100;
            label3.Text = "minutes.";
            // 
            // NewReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 711);
            this.ControlBox = false;
            this.Controls.Add(label3);
            this.Controls.Add(this.appConDataGridView);
            this.Controls.Add(reviewDateLabel);
            this.Controls.Add(this.reviewDateDateTimePicker);
            this.Controls.Add(this.appProDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(bottomLineLabel);
            this.Controls.Add(this.bottomLineTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingNumericUpDown);
            this.Controls.Add(timeSpentLabel);
            this.Controls.Add(this.timeSpentNumericUpDown);
            this.Controls.Add(reviewerLabel);
            this.Controls.Add(this.reviewerTextBox);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewReview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Review...";
            this.Load += new System.EventHandler(this.NewReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appProDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appProBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appConBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appConDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private ResearchDatabaseDataSet researchDatabaseDataSet;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.BindingSource reviewBindingSource;
        private ResearchDatabaseDataSetTableAdapters.ReviewTableAdapter reviewTableAdapter;
        private ResearchDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox reviewerTextBox;
        private System.Windows.Forms.NumericUpDown timeSpentNumericUpDown;
        private System.Windows.Forms.NumericUpDown ratingNumericUpDown;
        private System.Windows.Forms.TextBox bottomLineTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ResearchDatabaseDataSetTableAdapters.ApplicationReviewTableAdapter applicationReviewTableAdapter;
        private System.Windows.Forms.BindingSource appProBindingSource;
        private ResearchDatabaseDataSetTableAdapters.AppProTableAdapter appProTableAdapter;
        private System.Windows.Forms.DataGridView appProDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ResearchDatabaseDataSetTableAdapters.ReviewConTableAdapter reviewConTableAdapter;
        private ResearchDatabaseDataSetTableAdapters.ReviewProTableAdapter reviewProTableAdapter;
        private System.Windows.Forms.DateTimePicker reviewDateDateTimePicker;
        private System.Windows.Forms.BindingSource appConBindingSource;
        private ResearchDatabaseDataSetTableAdapters.AppConTableAdapter appConTableAdapter;
        private System.Windows.Forms.DataGridView appConDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}