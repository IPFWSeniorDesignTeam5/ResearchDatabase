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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReview));
            System.Windows.Forms.Label reviewDateLabel;
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.reviewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reviewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ReviewTableAdapter();
            this.tableAdapterManager = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager();
            this.applicationReviewTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationReviewTableAdapter();
            this.appProTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.AppProTableAdapter();
            this.reviewConTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ReviewConTableAdapter();
            this.reviewProTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ReviewProTableAdapter();
            this.reviewDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            reviewerLabel = new System.Windows.Forms.Label();
            timeSpentLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            bottomLineLabel = new System.Windows.Forms.Label();
            reviewDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingNavigator)).BeginInit();
            this.reviewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appProDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appProBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewerLabel
            // 
            reviewerLabel.AutoSize = true;
            reviewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reviewerLabel.Location = new System.Drawing.Point(74, 41);
            reviewerLabel.Name = "reviewerLabel";
            reviewerLabel.Size = new System.Drawing.Size(64, 13);
            reviewerLabel.TabIndex = 7;
            reviewerLabel.Text = "Reviewer:";
            // 
            // timeSpentLabel
            // 
            timeSpentLabel.AutoSize = true;
            timeSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeSpentLabel.Location = new System.Drawing.Point(217, 86);
            timeSpentLabel.Name = "timeSpentLabel";
            timeSpentLabel.Size = new System.Drawing.Size(130, 13);
            timeSpentLabel.TabIndex = 8;
            timeSpentLabel.Text = "Time Spent (minutes):";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ratingLabel.Location = new System.Drawing.Point(53, 129);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(85, 13);
            ratingLabel.TabIndex = 9;
            ratingLabel.Text = "Rating (1-10):";
            // 
            // bottomLineLabel
            // 
            bottomLineLabel.AutoSize = true;
            bottomLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bottomLineLabel.Location = new System.Drawing.Point(48, 171);
            bottomLineLabel.Name = "bottomLineLabel";
            bottomLineLabel.Size = new System.Drawing.Size(90, 13);
            bottomLineLabel.TabIndex = 10;
            bottomLineLabel.Text = "\"Bottom Line\":";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(274, 535);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(86, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKClicked);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(366, 535);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(86, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelClicked);
            // 
            // ErrorText
            // 
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(23, 505);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(421, 16);
            this.ErrorText.TabIndex = 6;
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reviewBindingNavigator
            // 
            this.reviewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reviewBindingNavigator.BindingSource = this.reviewBindingSource;
            this.reviewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reviewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reviewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.reviewBindingNavigatorSaveItem});
            this.reviewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reviewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reviewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reviewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reviewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reviewBindingNavigator.Name = "reviewBindingNavigator";
            this.reviewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reviewBindingNavigator.Size = new System.Drawing.Size(472, 25);
            this.reviewBindingNavigator.TabIndex = 7;
            this.reviewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // reviewBindingNavigatorSaveItem
            // 
            this.reviewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reviewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reviewBindingNavigatorSaveItem.Image")));
            this.reviewBindingNavigatorSaveItem.Name = "reviewBindingNavigatorSaveItem";
            this.reviewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reviewBindingNavigatorSaveItem.Text = "Save Data";
            this.reviewBindingNavigatorSaveItem.Click += new System.EventHandler(this.reviewBindingNavigatorSaveItem_Click);
            // 
            // reviewerTextBox
            // 
            this.reviewerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "Reviewer", true));
            this.reviewerTextBox.Location = new System.Drawing.Point(144, 38);
            this.reviewerTextBox.Name = "reviewerTextBox";
            this.reviewerTextBox.Size = new System.Drawing.Size(203, 20);
            this.reviewerTextBox.TabIndex = 8;
            // 
            // timeSpentNumericUpDown
            // 
            this.timeSpentNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reviewBindingSource, "TimeSpent", true));
            this.timeSpentNumericUpDown.Location = new System.Drawing.Point(353, 83);
            this.timeSpentNumericUpDown.Name = "timeSpentNumericUpDown";
            this.timeSpentNumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.timeSpentNumericUpDown.TabIndex = 9;
            // 
            // ratingNumericUpDown
            // 
            this.ratingNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reviewBindingSource, "Rating", true));
            this.ratingNumericUpDown.Location = new System.Drawing.Point(144, 125);
            this.ratingNumericUpDown.Name = "ratingNumericUpDown";
            this.ratingNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.ratingNumericUpDown.TabIndex = 10;
            // 
            // bottomLineTextBox
            // 
            this.bottomLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "BottomLine", true));
            this.bottomLineTextBox.Location = new System.Drawing.Point(144, 168);
            this.bottomLineTextBox.Multiline = true;
            this.bottomLineTextBox.Name = "bottomLineTextBox";
            this.bottomLineTextBox.Size = new System.Drawing.Size(289, 85);
            this.bottomLineTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
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
            this.appProDataGridView.Location = new System.Drawing.Point(18, 287);
            this.appProDataGridView.Name = "appProDataGridView";
            this.appProDataGridView.Size = new System.Drawing.Size(426, 96);
            this.appProDataGridView.TabIndex = 15;
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
            // researchDatabaseDataSet
            // 
            this.researchDatabaseDataSet.DataSetName = "ResearchDatabaseDataSet";
            this.researchDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewBindingSource
            // 
            this.reviewBindingSource.DataMember = "Review";
            this.reviewBindingSource.DataSource = this.researchDatabaseDataSet;
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
            // reviewDateLabel
            // 
            reviewDateLabel.AutoSize = true;
            reviewDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reviewDateLabel.Location = new System.Drawing.Point(18, 86);
            reviewDateLabel.Name = "reviewDateLabel";
            reviewDateLabel.Size = new System.Drawing.Size(84, 13);
            reviewDateLabel.TabIndex = 15;
            reviewDateLabel.Text = "Review Date:";
            // 
            // reviewDateDateTimePicker
            // 
            this.reviewDateDateTimePicker.CustomFormat = "";
            this.reviewDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reviewBindingSource, "ReviewDate", true));
            this.reviewDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reviewDateDateTimePicker.Location = new System.Drawing.Point(106, 83);
            this.reviewDateDateTimePicker.Name = "reviewDateDateTimePicker";
            this.reviewDateDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.reviewDateDateTimePicker.TabIndex = 16;
            // 
            // NewReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 578);
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
            this.Controls.Add(this.reviewBindingNavigator);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Name = "NewReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Review...";
            this.Load += new System.EventHandler(this.NewReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingNavigator)).EndInit();
            this.reviewBindingNavigator.ResumeLayout(false);
            this.reviewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appProDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appProBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingNavigator reviewBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton reviewBindingNavigatorSaveItem;
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
    }
}