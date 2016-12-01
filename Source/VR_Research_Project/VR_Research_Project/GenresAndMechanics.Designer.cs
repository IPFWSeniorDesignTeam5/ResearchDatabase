namespace VR_Research_Project
{
    partial class GenresAndMechanics
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
            this.GenreAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationGenreRelationTableAdapter();
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.MechanicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MechanicAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationMechanicRelationTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenreAdapter
            // 
            this.GenreAdapter.ClearBeforeFill = true;
            // 
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.AllowUserToDeleteRows = false;
            this.MainGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGridView.AutoGenerateColumns = false;
            this.MainGridView.BackgroundColor = System.Drawing.Color.White;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.descriptionDataGridViewTextBoxColumn,
            this.applicationIdDataGridViewTextBoxColumn});
            this.MainGridView.DataSource = this.GenreBindingSource;
            this.MainGridView.Location = new System.Drawing.Point(0, 0);
            this.MainGridView.Margin = new System.Windows.Forms.Padding(4);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.Size = new System.Drawing.Size(428, 592);
            this.MainGridView.TabIndex = 0;
            this.MainGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellClicked);
            this.MainGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValueChanged);
            // 
            // Selected
            // 
            this.Selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Selected.DataPropertyName = "Selected";
            this.Selected.FalseValue = "0";
            this.Selected.HeaderText = "Sel";
            this.Selected.IndeterminateValue = "";
            this.Selected.Name = "Selected";
            this.Selected.TrueValue = "1";
            this.Selected.Width = 34;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicationIdDataGridViewTextBoxColumn
            // 
            this.applicationIdDataGridViewTextBoxColumn.DataPropertyName = "ApplicationId";
            this.applicationIdDataGridViewTextBoxColumn.HeaderText = "ApplicationId";
            this.applicationIdDataGridViewTextBoxColumn.Name = "applicationIdDataGridViewTextBoxColumn";
            this.applicationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // GenreBindingSource
            // 
            this.GenreBindingSource.DataMember = "ApplicationGenreRelation";
            this.GenreBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // researchDatabaseDataSet
            // 
            this.researchDatabaseDataSet.DataSetName = "ResearchDatabaseDataSet";
            this.researchDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MechanicBindingSource
            // 
            this.MechanicBindingSource.DataMember = "ApplicationMechanicRelation";
            this.MechanicBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // MechanicAdapter
            // 
            this.MechanicAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newLabel);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 43);
            this.panel1.TabIndex = 1;
            // 
            // newLabel
            // 
            this.newLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newLabel.Location = new System.Drawing.Point(255, 14);
            this.newLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(124, 16);
            this.newLabel.TabIndex = 1;
            this.newLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddButton.Enabled = false;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(384, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(44, 43);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_clicked);
            // 
            // GenresAndMechanics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenresAndMechanics";
            this.Size = new System.Drawing.Size(428, 642);
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ResearchDatabaseDataSetTableAdapters.ApplicationGenreRelationTableAdapter GenreAdapter;
        private System.Windows.Forms.DataGridView MainGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource GenreBindingSource;
        private ResearchDatabaseDataSet researchDatabaseDataSet;
        private System.Windows.Forms.BindingSource MechanicBindingSource;
        private ResearchDatabaseDataSetTableAdapters.ApplicationMechanicRelationTableAdapter MechanicAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label newLabel;
    }
}
