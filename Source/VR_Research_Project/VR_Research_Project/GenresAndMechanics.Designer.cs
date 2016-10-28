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
            this.GenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.MechanicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MechanicAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationMechanicRelationTableAdapter();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicBindingSource)).BeginInit();
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
            this.MainGridView.AutoGenerateColumns = false;
            this.MainGridView.BackgroundColor = System.Drawing.Color.White;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.descriptionDataGridViewTextBoxColumn,
            this.applicationIdDataGridViewTextBoxColumn});
            this.MainGridView.DataSource = this.GenreBindingSource;
            this.MainGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGridView.Location = new System.Drawing.Point(0, 0);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.Size = new System.Drawing.Size(321, 522);
            this.MainGridView.TabIndex = 0;
            this.MainGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValueChanged);
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
            // Selected
            // 
            this.Selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Selected.DataPropertyName = "Selected";
            this.Selected.FalseValue = "0";
            this.Selected.HeaderText = "Sel";
            this.Selected.IndeterminateValue = "";
            this.Selected.Name = "Selected";
            this.Selected.TrueValue = "1";
            this.Selected.Width = 28;
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
            // GenresAndMechanics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainGridView);
            this.Name = "GenresAndMechanics";
            this.Size = new System.Drawing.Size(321, 522);
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicBindingSource)).EndInit();
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
    }
}
