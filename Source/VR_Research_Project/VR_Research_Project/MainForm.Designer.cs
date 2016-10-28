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
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label mechanicDescriptionLabel;
            System.Windows.Forms.Label generalDescriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listBox_Applications = new System.Windows.Forms.ListBox();
            this.applicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.label_Applications = new System.Windows.Forms.Label();
            this.MainTabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.nameComboBox1 = new System.Windows.Forms.ComboBox();
            this.platformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generalDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.mechanicDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateTextBox = new System.Windows.Forms.TextBox();
            this.GenresAndMechanicsTab = new System.Windows.Forms.TabPage();
            this.MechanicsControl = new VR_Research_Project.GenresAndMechanics();
            this.GenresControl = new VR_Research_Project.GenresAndMechanics();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.applicationTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter();
            this.tableAdapterManager = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.developerTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.DeveloperTableAdapter();
            this.applicationGenreTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationGenreTableAdapter();
            this.platformTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.PlatformTableAdapter();
            releaseDateLabel = new System.Windows.Forms.Label();
            mechanicDescriptionLabel = new System.Windows.Forms.Label();
            generalDescriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            this.MainTabcontrol.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platformBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource1)).BeginInit();
            this.GenresAndMechanicsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(75, 88);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 0;
            releaseDateLabel.Text = "Release Date:";
            // 
            // mechanicDescriptionLabel
            // 
            mechanicDescriptionLabel.AutoSize = true;
            mechanicDescriptionLabel.Location = new System.Drawing.Point(37, 350);
            mechanicDescriptionLabel.Name = "mechanicDescriptionLabel";
            mechanicDescriptionLabel.Size = new System.Drawing.Size(113, 13);
            mechanicDescriptionLabel.TabIndex = 4;
            mechanicDescriptionLabel.Text = "Mechanic Description:";
            // 
            // generalDescriptionLabel
            // 
            generalDescriptionLabel.AutoSize = true;
            generalDescriptionLabel.Location = new System.Drawing.Point(47, 190);
            generalDescriptionLabel.Name = "generalDescriptionLabel";
            generalDescriptionLabel.Size = new System.Drawing.Size(103, 13);
            generalDescriptionLabel.TabIndex = 6;
            generalDescriptionLabel.Text = "General Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(91, 37);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(59, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Developer:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(91, 135);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(48, 13);
            nameLabel1.TabIndex = 8;
            nameLabel1.Text = "Platform:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.toolStripButton1.Click += new System.EventHandler(this.NewApplicationClicked);
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
            this.listBox_Applications.TabIndex = 1;
            this.listBox_Applications.ValueMember = "Id";
            this.listBox_Applications.SelectedIndexChanged += new System.EventHandler(this.ApplicationSelected);
            // 
            // applicationBindingSource
            // 
            this.applicationBindingSource.DataMember = "Application";
            this.applicationBindingSource.DataSource = this.researchDatabaseDataSet;
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
            // MainTabcontrol
            // 
            this.MainTabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabcontrol.Controls.Add(this.tabPage_General);
            this.MainTabcontrol.Controls.Add(this.GenresAndMechanicsTab);
            this.MainTabcontrol.Controls.Add(this.tabPage1);
            this.MainTabcontrol.Controls.Add(this.tabPage2);
            this.MainTabcontrol.Location = new System.Drawing.Point(306, 70);
            this.MainTabcontrol.Name = "MainTabcontrol";
            this.MainTabcontrol.SelectedIndex = 0;
            this.MainTabcontrol.Size = new System.Drawing.Size(537, 539);
            this.MainTabcontrol.TabIndex = 4;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(nameLabel1);
            this.tabPage_General.Controls.Add(this.nameComboBox1);
            this.tabPage_General.Controls.Add(nameLabel);
            this.tabPage_General.Controls.Add(this.nameComboBox);
            this.tabPage_General.Controls.Add(generalDescriptionLabel);
            this.tabPage_General.Controls.Add(this.generalDescriptionTextBox);
            this.tabPage_General.Controls.Add(mechanicDescriptionLabel);
            this.tabPage_General.Controls.Add(this.mechanicDescriptionTextBox);
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
            // nameComboBox1
            // 
            this.nameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.platformBindingSource, "Name", true));
            this.nameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicationBindingSource, "Platform", true));
            this.nameComboBox1.DataSource = this.platformBindingSource;
            this.nameComboBox1.DisplayMember = "Name";
            this.nameComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox1.FormattingEnabled = true;
            this.nameComboBox1.Location = new System.Drawing.Point(156, 132);
            this.nameComboBox1.Name = "nameComboBox1";
            this.nameComboBox1.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox1.TabIndex = 9;
            this.nameComboBox1.ValueMember = "Id";
            // 
            // platformBindingSource
            // 
            this.platformBindingSource.DataMember = "Platform";
            this.platformBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "Name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicationBindingSource, "DeveloperId", true));
            this.nameComboBox.DataSource = this.developerBindingSource1;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(156, 34);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox.TabIndex = 8;
            this.nameComboBox.ValueMember = "Id";
            // 
            // developerBindingSource
            // 
            this.developerBindingSource.DataMember = "Developer";
            this.developerBindingSource.DataSource = this.researchDatabaseDataSet;
            // 
            // developerBindingSource1
            // 
            this.developerBindingSource1.DataMember = "Developer";
            this.developerBindingSource1.DataSource = this.researchDatabaseDataSet;
            // 
            // generalDescriptionTextBox
            // 
            this.generalDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationBindingSource, "GeneralDescription", true));
            this.generalDescriptionTextBox.Location = new System.Drawing.Point(156, 187);
            this.generalDescriptionTextBox.Multiline = true;
            this.generalDescriptionTextBox.Name = "generalDescriptionTextBox";
            this.generalDescriptionTextBox.Size = new System.Drawing.Size(325, 108);
            this.generalDescriptionTextBox.TabIndex = 7;
            // 
            // mechanicDescriptionTextBox
            // 
            this.mechanicDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mechanicDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationBindingSource, "MechanicDescription", true));
            this.mechanicDescriptionTextBox.Location = new System.Drawing.Point(156, 347);
            this.mechanicDescriptionTextBox.Multiline = true;
            this.mechanicDescriptionTextBox.Name = "mechanicDescriptionTextBox";
            this.mechanicDescriptionTextBox.Size = new System.Drawing.Size(330, 127);
            this.mechanicDescriptionTextBox.TabIndex = 5;
            // 
            // releaseDateTextBox
            // 
            this.releaseDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicationBindingSource, "ReleaseDate", true));
            this.releaseDateTextBox.Location = new System.Drawing.Point(156, 85);
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.releaseDateTextBox.TabIndex = 1;
            // 
            // GenresAndMechanicsTab
            // 
            this.GenresAndMechanicsTab.Controls.Add(this.MechanicsControl);
            this.GenresAndMechanicsTab.Controls.Add(this.GenresControl);
            this.GenresAndMechanicsTab.Location = new System.Drawing.Point(4, 22);
            this.GenresAndMechanicsTab.Name = "GenresAndMechanicsTab";
            this.GenresAndMechanicsTab.Padding = new System.Windows.Forms.Padding(3);
            this.GenresAndMechanicsTab.Size = new System.Drawing.Size(529, 513);
            this.GenresAndMechanicsTab.TabIndex = 1;
            this.GenresAndMechanicsTab.Text = "Genres/Mechanics";
            this.GenresAndMechanicsTab.UseVisualStyleBackColor = true;
            // 
            // MechanicsControl
            // 
            this.MechanicsControl.Location = new System.Drawing.Point(276, 42);
            this.MechanicsControl.Name = "MechanicsControl";
            this.MechanicsControl.Size = new System.Drawing.Size(247, 465);
            this.MechanicsControl.TabIndex = 1;
            // 
            // GenresControl
            // 
            this.GenresControl.Location = new System.Drawing.Point(6, 42);
            this.GenresControl.Name = "GenresControl";
            this.GenresControl.Size = new System.Drawing.Size(247, 465);
            this.GenresControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 513);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reviews";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 513);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Reporting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // applicationTableAdapter
            // 
            this.applicationTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PlatformTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // developerTableAdapter
            // 
            this.developerTableAdapter.ClearBeforeFill = true;
            // 
            // applicationGenreTableAdapter
            // 
            this.applicationGenreTableAdapter.ClearBeforeFill = true;
            // 
            // platformTableAdapter
            // 
            this.platformTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 631);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.MainTabcontrol);
            this.Controls.Add(this.label_Applications);
            this.Controls.Add(this.listBox_Applications);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "VR Research Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            this.MainTabcontrol.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platformBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource1)).EndInit();
            this.GenresAndMechanicsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox listBox_Applications;
        private ResearchDatabaseDataSet researchDatabaseDataSet;
        private System.Windows.Forms.Label label_Applications;
        private System.Windows.Forms.TabControl MainTabcontrol;
        private System.Windows.Forms.TabPage GenresAndMechanicsTab;
        private System.Windows.Forms.BindingSource applicationBindingSource;
        private ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter applicationTableAdapter;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TextBox releaseDateTextBox;
        private ResearchDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox1;
        private GenresAndMechanics GenresControl;
        private GenresAndMechanics MechanicsControl;
        private System.Windows.Forms.TextBox generalDescriptionTextBox;
        private System.Windows.Forms.TextBox mechanicDescriptionTextBox;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private ResearchDatabaseDataSetTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox nameComboBox;
        private ResearchDatabaseDataSetTableAdapters.ApplicationGenreTableAdapter applicationGenreTableAdapter;
        private System.Windows.Forms.BindingSource developerBindingSource1;
        private System.Windows.Forms.BindingSource platformBindingSource;
        private ResearchDatabaseDataSetTableAdapters.PlatformTableAdapter platformTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox1;
    }
}

