namespace VR_Research_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label nameLabel;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listBox_Applications = new System.Windows.Forms.ListBox();
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.label_Applications = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Reviews = new System.Windows.Forms.TabPage();
            this.button_NewReview = new System.Windows.Forms.Button();
            this.applicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.tableAdapterManager = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager();
            this.releaseDateTextBox = new System.Windows.Forms.TextBox();
            this.platformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.platformTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.PlatformTableAdapter();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            releaseDateLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_Reviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).BeginInit();
            this.tabPage_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 22);
            this.toolStripButton1.Text = "New Application...";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // listBox_Applications
            // 
            this.listBox_Applications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Applications.DataSource = this.applicationBindingSource;
            this.listBox_Applications.DisplayMember = "Name";
            this.listBox_Applications.FormattingEnabled = true;
            this.listBox_Applications.Location = new System.Drawing.Point(13, 70);
            this.listBox_Applications.Name = "listBox_Applications";
            this.listBox_Applications.Size = new System.Drawing.Size(275, 537);
            this.listBox_Applications.Sorted = true;
            this.listBox_Applications.TabIndex = 1;
            this.listBox_Applications.ValueMember = "Id";
            // 
            // researchDatabaseDataSet
            // 
            this.researchDatabaseDataSet.DataSetName = "ResearchDatabaseDataSet";
            this.researchDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_Applications
            // 
            this.label_Applications.AutoSize = true;
            this.label_Applications.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Applications.Location = new System.Drawing.Point(12, 40);
            this.label_Applications.Name = "label_Applications";
            this.label_Applications.Size = new System.Drawing.Size(99, 18);
            this.label_Applications.TabIndex = 3;
            this.label_Applications.Text = "Applications";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_General);
            this.tabControl1.Controls.Add(this.tabPage_Reviews);
            this.tabControl1.Location = new System.Drawing.Point(306, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 539);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_Reviews
            // 
            this.tabPage_Reviews.Controls.Add(this.button_NewReview);
            this.tabPage_Reviews.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Reviews.Name = "tabPage_Reviews";
            this.tabPage_Reviews.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Reviews.Size = new System.Drawing.Size(521, 555);
            this.tabPage_Reviews.TabIndex = 1;
            this.tabPage_Reviews.Text = "Reviews";
            this.tabPage_Reviews.UseVisualStyleBackColor = true;
            // 
            // button_NewReview
            // 
            this.button_NewReview.Location = new System.Drawing.Point(420, 6);
            this.button_NewReview.Name = "button_NewReview";
            this.button_NewReview.Size = new System.Drawing.Size(95, 23);
            this.button_NewReview.TabIndex = 0;
            this.button_NewReview.Text = "New Review...";
            this.button_NewReview.UseVisualStyleBackColor = true;
            // 
            // applicationBindingSource
            // 
            this.applicationBindingSource.DataMember = "Application";
            this.applicationBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // applicationTableAdapter
            // 
            this.applicationTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(nameLabel);
            this.tabPage_General.Controls.Add(this.nameTextBox);
            this.tabPage_General.Controls.Add(releaseDateLabel);
            this.tabPage_General.Controls.Add(this.releaseDateTextBox);
            this.tabPage_General.Location = new System.Drawing.Point(4, 22);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(529, 513);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "General";
            this.tabPage_General.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicationGenreTableAdapter = null;
            this.tableAdapterManager.ApplicationMechanicTableAdapter = null;
            this.tableAdapterManager.ApplicationReviewTableAdapter = null;
            this.tableAdapterManager.ApplicationTableAdapter = this.applicationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeveloperTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MechanicTableAdapter = null;
            this.tableAdapterManager.PlatformTableAdapter = this.platformTableAdapter;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(30, 27);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 0;
            releaseDateLabel.Text = "Release Date:";
            // 
            // releaseDateTextBox
            // 
            this.releaseDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationBindingSource, "ReleaseDate", true));
            this.releaseDateTextBox.Location = new System.Drawing.Point(111, 24);
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.releaseDateTextBox.TabIndex = 1;
            // 
            // platformBindingSource
            // 
            this.platformBindingSource.DataMember = "Platform";
            this.platformBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // platformTableAdapter
            // 
            this.platformTableAdapter.ClearBeforeFill = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(57, 71);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Platform:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.platformBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(111, 68);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationBindingSource, "Name", true));
            this.nameTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameTextBox1.Location = new System.Drawing.Point(310, 25);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.ReadOnly = true;
            this.nameTextBox1.Size = new System.Drawing.Size(529, 22);
            this.nameTextBox1.TabIndex = 5;
            this.nameTextBox1.TabStop = false;
            this.nameTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 631);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_Applications);
            this.Controls.Add(this.listBox_Applications);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "VR Research Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Reviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).EndInit();
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platformBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox listBox_Applications;
        private ResearchDatabaseDataSet researchDatabaseDataSet;
        private System.Windows.Forms.Label label_Applications;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Reviews;
        private System.Windows.Forms.Button button_NewReview;
        private System.Windows.Forms.BindingSource applicationBindingSource;
        private ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter applicationTableAdapter;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TextBox releaseDateTextBox;
        private ResearchDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ResearchDatabaseDataSetTableAdapters.PlatformTableAdapter platformTableAdapter;
        private System.Windows.Forms.BindingSource platformBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox nameTextBox1;
    }
}

