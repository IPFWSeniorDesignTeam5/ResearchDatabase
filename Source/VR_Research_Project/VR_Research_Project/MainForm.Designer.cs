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
            System.Windows.Forms.Label mechanicDescriptionLabel;
            System.Windows.Forms.Label generalDescriptionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label releaseDateLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolstripApplications_button = new System.Windows.Forms.ToolStripButton();
            this.ToolstripReporting_button = new System.Windows.Forms.ToolStripButton();
            this.SearchToolstripButton = new System.Windows.Forms.ToolStripButton();
            this.listBox_Applications = new System.Windows.Forms.ListBox();
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.label_Applications = new System.Windows.Forms.Label();
            this.MainTabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nameComboBox1 = new System.Windows.Forms.ComboBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.generalDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.mechanicDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.GenresAndMechanicsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GenresControl = new VR_Research_Project.GenresAndMechanics();
            this.label1 = new System.Windows.Forms.Label();
            this.MechanicsControl = new VR_Research_Project.GenresAndMechanics();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AppReviews = new VR_Research_Project.AppReviews();
            this.applicationTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter();
            this.tableAdapterManager = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager();
            this.applicationGenreTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.ApplicationGenreTableAdapter();
            this.developerTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.DeveloperTableAdapter();
            this.platformTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.PlatformTableAdapter();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.DeleteApplication = new System.Windows.Forms.Button();
            this.newApplicationButton = new System.Windows.Forms.Button();
            mechanicDescriptionLabel = new System.Windows.Forms.Label();
            generalDescriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            releaseDateLabel1 = new System.Windows.Forms.Label();
            this.MainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            this.MainTabcontrol.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.GenresAndMechanicsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mechanicDescriptionLabel
            // 
            mechanicDescriptionLabel.AutoSize = true;
            mechanicDescriptionLabel.Location = new System.Drawing.Point(49, 431);
            mechanicDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mechanicDescriptionLabel.Name = "mechanicDescriptionLabel";
            mechanicDescriptionLabel.Size = new System.Drawing.Size(147, 17);
            mechanicDescriptionLabel.TabIndex = 0;
            mechanicDescriptionLabel.Text = "Mechanic Description:";
            // 
            // generalDescriptionLabel
            // 
            generalDescriptionLabel.AutoSize = true;
            generalDescriptionLabel.Location = new System.Drawing.Point(63, 234);
            generalDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            generalDescriptionLabel.Name = "generalDescriptionLabel";
            generalDescriptionLabel.Size = new System.Drawing.Size(138, 17);
            generalDescriptionLabel.TabIndex = 0;
            generalDescriptionLabel.Text = "General Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(121, 46);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(77, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Developer:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(121, 166);
            nameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(64, 17);
            nameLabel1.TabIndex = 0;
            nameLabel1.Text = "Platform:";
            // 
            // releaseDateLabel1
            // 
            releaseDateLabel1.AutoSize = true;
            releaseDateLabel1.Location = new System.Drawing.Point(100, 108);
            releaseDateLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            releaseDateLabel1.Name = "releaseDateLabel1";
            releaseDateLabel1.Size = new System.Drawing.Size(98, 17);
            releaseDateLabel1.TabIndex = 0;
            releaseDateLabel1.Text = "Release Date:";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolstripApplications_button,
            this.ToolstripReporting_button,
            this.SearchToolstripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1225, 27);
            this.MainToolStrip.TabIndex = 0;
            // 
            // ToolstripApplications_button
            // 
            this.ToolstripApplications_button.Checked = true;
            this.ToolstripApplications_button.CheckOnClick = true;
            this.ToolstripApplications_button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolstripApplications_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolstripApplications_button.Image = ((System.Drawing.Image)(resources.GetObject("ToolstripApplications_button.Image")));
            this.ToolstripApplications_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolstripApplications_button.Name = "ToolstripApplications_button";
            this.ToolstripApplications_button.Size = new System.Drawing.Size(96, 24);
            this.ToolstripApplications_button.Text = "Applications";
            this.ToolstripApplications_button.Click += new System.EventHandler(this.ToolbarButton_clicked);
            // 
            // ToolstripReporting_button
            // 
            this.ToolstripReporting_button.BackColor = System.Drawing.SystemColors.Control;
            this.ToolstripReporting_button.CheckOnClick = true;
            this.ToolstripReporting_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolstripReporting_button.Image = ((System.Drawing.Image)(resources.GetObject("ToolstripReporting_button.Image")));
            this.ToolstripReporting_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolstripReporting_button.Name = "ToolstripReporting_button";
            this.ToolstripReporting_button.Size = new System.Drawing.Size(79, 24);
            this.ToolstripReporting_button.Text = "Reporting";
            this.ToolstripReporting_button.Click += new System.EventHandler(this.ToolbarButton_clicked);
            // 
            // SearchToolstripButton
            // 
            this.SearchToolstripButton.CheckOnClick = true;
            this.SearchToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchToolstripButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchToolstripButton.Image")));
            this.SearchToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchToolstripButton.Name = "SearchToolstripButton";
            this.SearchToolstripButton.Size = new System.Drawing.Size(57, 24);
            this.SearchToolstripButton.Text = "Search";
            this.SearchToolstripButton.Click += new System.EventHandler(this.ToolbarButton_clicked);
            // 
            // listBox_Applications
            // 
            this.listBox_Applications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Applications.DataSource = this.researchDatabaseDataSet;
            this.listBox_Applications.DisplayMember = "Application.Name";
            this.listBox_Applications.FormattingEnabled = true;
            this.listBox_Applications.ItemHeight = 16;
            this.listBox_Applications.Location = new System.Drawing.Point(17, 86);
            this.listBox_Applications.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Applications.Name = "listBox_Applications";
            this.listBox_Applications.Size = new System.Drawing.Size(365, 660);
            this.listBox_Applications.TabIndex = 0;
            this.listBox_Applications.ValueMember = "Application.Id";
            this.listBox_Applications.SelectedIndexChanged += new System.EventHandler(this.ApplicationSelected);
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
            this.label_Applications.Location = new System.Drawing.Point(16, 49);
            this.label_Applications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Applications.Name = "label_Applications";
            this.label_Applications.Size = new System.Drawing.Size(124, 24);
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
            this.MainTabcontrol.Location = new System.Drawing.Point(408, 86);
            this.MainTabcontrol.Margin = new System.Windows.Forms.Padding(4);
            this.MainTabcontrol.Name = "MainTabcontrol";
            this.MainTabcontrol.SelectedIndex = 0;
            this.MainTabcontrol.Size = new System.Drawing.Size(801, 699);
            this.MainTabcontrol.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.AutoScroll = true;
            this.tabPage_General.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_General.Controls.Add(this.dateTimePicker1);
            this.tabPage_General.Controls.Add(releaseDateLabel1);
            this.tabPage_General.Controls.Add(nameLabel1);
            this.tabPage_General.Controls.Add(this.nameComboBox1);
            this.tabPage_General.Controls.Add(nameLabel);
            this.tabPage_General.Controls.Add(this.nameComboBox);
            this.tabPage_General.Controls.Add(generalDescriptionLabel);
            this.tabPage_General.Controls.Add(this.generalDescriptionTextBox);
            this.tabPage_General.Controls.Add(mechanicDescriptionLabel);
            this.tabPage_General.Controls.Add(this.mechanicDescriptionTextBox);
            this.tabPage_General.Location = new System.Drawing.Point(4, 25);
            this.tabPage_General.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_General.Size = new System.Drawing.Size(793, 670);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "General";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.researchDatabaseDataSet, "Application.ReleaseDate", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 108);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // nameComboBox1
            // 
            this.nameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.researchDatabaseDataSet, "Application.Platform", true));
            this.nameComboBox1.DataSource = this.researchDatabaseDataSet;
            this.nameComboBox1.DisplayMember = "Platform.Name";
            this.nameComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox1.FormattingEnabled = true;
            this.nameComboBox1.Location = new System.Drawing.Point(208, 162);
            this.nameComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.nameComboBox1.Name = "nameComboBox1";
            this.nameComboBox1.Size = new System.Drawing.Size(160, 24);
            this.nameComboBox1.TabIndex = 3;
            this.nameComboBox1.ValueMember = "Platform.Id";
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.researchDatabaseDataSet, "Application.DeveloperId", true));
            this.nameComboBox.DataSource = this.researchDatabaseDataSet;
            this.nameComboBox.DisplayMember = "Developer.Name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(208, 42);
            this.nameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(257, 24);
            this.nameComboBox.TabIndex = 1;
            this.nameComboBox.ValueMember = "Developer.Id";
            // 
            // generalDescriptionTextBox
            // 
            this.generalDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalDescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.generalDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.researchDatabaseDataSet, "Application.GeneralDescription", true));
            this.generalDescriptionTextBox.Location = new System.Drawing.Point(208, 230);
            this.generalDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.generalDescriptionTextBox.MaxLength = 1200;
            this.generalDescriptionTextBox.Multiline = true;
            this.generalDescriptionTextBox.Name = "generalDescriptionTextBox";
            this.generalDescriptionTextBox.Size = new System.Drawing.Size(515, 150);
            this.generalDescriptionTextBox.TabIndex = 4;
            // 
            // mechanicDescriptionTextBox
            // 
            this.mechanicDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mechanicDescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.mechanicDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.researchDatabaseDataSet, "Application.MechanicDescription", true));
            this.mechanicDescriptionTextBox.Location = new System.Drawing.Point(208, 427);
            this.mechanicDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mechanicDescriptionTextBox.MaxLength = 1200;
            this.mechanicDescriptionTextBox.Multiline = true;
            this.mechanicDescriptionTextBox.Name = "mechanicDescriptionTextBox";
            this.mechanicDescriptionTextBox.Size = new System.Drawing.Size(515, 153);
            this.mechanicDescriptionTextBox.TabIndex = 5;
            // 
            // GenresAndMechanicsTab
            // 
            this.GenresAndMechanicsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GenresAndMechanicsTab.Controls.Add(this.splitContainer1);
            this.GenresAndMechanicsTab.Location = new System.Drawing.Point(4, 25);
            this.GenresAndMechanicsTab.Margin = new System.Windows.Forms.Padding(4);
            this.GenresAndMechanicsTab.Name = "GenresAndMechanicsTab";
            this.GenresAndMechanicsTab.Padding = new System.Windows.Forms.Padding(4);
            this.GenresAndMechanicsTab.Size = new System.Drawing.Size(793, 670);
            this.GenresAndMechanicsTab.TabIndex = 1;
            this.GenresAndMechanicsTab.Text = "Genres/Mechanics";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GenresControl);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MechanicsControl);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(785, 662);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // GenresControl
            // 
            this.GenresControl.AutoSize = true;
            this.GenresControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenresControl.Location = new System.Drawing.Point(0, 16);
            this.GenresControl.Margin = new System.Windows.Forms.Padding(5);
            this.GenresControl.Name = "GenresControl";
            this.GenresControl.Size = new System.Drawing.Size(391, 646);
            this.GenresControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MechanicsControl
            // 
            this.MechanicsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MechanicsControl.Location = new System.Drawing.Point(0, 16);
            this.MechanicsControl.Margin = new System.Windows.Forms.Padding(5);
            this.MechanicsControl.Name = "MechanicsControl";
            this.MechanicsControl.Size = new System.Drawing.Size(389, 646);
            this.MechanicsControl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mechanics";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.AppReviews);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(793, 670);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reviews";
            // 
            // AppReviews
            // 
            this.AppReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppReviews.Location = new System.Drawing.Point(4, 4);
            this.AppReviews.Margin = new System.Windows.Forms.Padding(5);
            this.AppReviews.Name = "AppReviews";
            this.AppReviews.Size = new System.Drawing.Size(785, 662);
            this.AppReviews.TabIndex = 0;
            // 
            // applicationTableAdapter
            // 
            this.applicationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppConTableAdapter = null;
            this.tableAdapterManager.ApplicationGenreTableAdapter = this.applicationGenreTableAdapter;
            this.tableAdapterManager.ApplicationMechanicTableAdapter = null;
            this.tableAdapterManager.ApplicationReviewTableAdapter = null;
            this.tableAdapterManager.ApplicationTableAdapter = this.applicationTableAdapter;
            this.tableAdapterManager.AppProTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeveloperTableAdapter = this.developerTableAdapter;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MechanicTableAdapter = null;
            this.tableAdapterManager.PlatformTableAdapter = this.platformTableAdapter;
            this.tableAdapterManager.ReviewConTableAdapter = null;
            this.tableAdapterManager.ReviewProTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VR_Research_Project.ResearchDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // applicationGenreTableAdapter
            // 
            this.applicationGenreTableAdapter.ClearBeforeFill = true;
            // 
            // developerTableAdapter
            // 
            this.developerTableAdapter.ClearBeforeFill = true;
            // 
            // platformTableAdapter
            // 
            this.platformTableAdapter.ClearBeforeFill = true;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameTextBox1.Location = new System.Drawing.Point(413, 31);
            this.nameTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.ReadOnly = true;
            this.nameTextBox1.Size = new System.Drawing.Size(705, 27);
            this.nameTextBox1.TabIndex = 5;
            this.nameTextBox1.TabStop = false;
            this.nameTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteApplication
            // 
            this.DeleteApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteApplication.Enabled = false;
            this.DeleteApplication.Location = new System.Drawing.Point(284, 754);
            this.DeleteApplication.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteApplication.Name = "DeleteApplication";
            this.DeleteApplication.Size = new System.Drawing.Size(100, 26);
            this.DeleteApplication.TabIndex = 6;
            this.DeleteApplication.Text = "Delete";
            this.DeleteApplication.UseVisualStyleBackColor = true;
            this.DeleteApplication.Click += new System.EventHandler(this.DeleteApplication_clicked);
            // 
            // newApplicationButton
            // 
            this.newApplicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newApplicationButton.Location = new System.Drawing.Point(17, 754);
            this.newApplicationButton.Margin = new System.Windows.Forms.Padding(4);
            this.newApplicationButton.Name = "newApplicationButton";
            this.newApplicationButton.Size = new System.Drawing.Size(100, 26);
            this.newApplicationButton.TabIndex = 7;
            this.newApplicationButton.Text = "New...";
            this.newApplicationButton.UseVisualStyleBackColor = true;
            this.newApplicationButton.Click += new System.EventHandler(this.NewApplicationClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1225, 812);
            this.Controls.Add(this.newApplicationButton);
            this.Controls.Add(this.DeleteApplication);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.MainTabcontrol);
            this.Controls.Add(this.label_Applications);
            this.Controls.Add(this.listBox_Applications);
            this.Controls.Add(this.MainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VR Research Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            this.MainTabcontrol.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_General.PerformLayout();
            this.GenresAndMechanicsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton ToolstripApplications_button;
        private System.Windows.Forms.ListBox listBox_Applications;
        private ResearchDatabaseDataSet researchDatabaseDataSet;
        private System.Windows.Forms.Label label_Applications;
        private System.Windows.Forms.TabControl MainTabcontrol;
        private System.Windows.Forms.TabPage GenresAndMechanicsTab;
        private ResearchDatabaseDataSetTableAdapters.ApplicationTableAdapter applicationTableAdapter;
        private System.Windows.Forms.TabPage tabPage_General;
        private ResearchDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox1;
        private GenresAndMechanics GenresControl;
        private GenresAndMechanics MechanicsControl;
        private System.Windows.Forms.TextBox generalDescriptionTextBox;
        private System.Windows.Forms.TextBox mechanicDescriptionTextBox;
        private ResearchDatabaseDataSetTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox nameComboBox;
        private ResearchDatabaseDataSetTableAdapters.ApplicationGenreTableAdapter applicationGenreTableAdapter;
        private ResearchDatabaseDataSetTableAdapters.PlatformTableAdapter platformTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button DeleteApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton ToolstripReporting_button;
        private System.Windows.Forms.Button newApplicationButton;
        private AppReviews AppReviews;
        private System.Windows.Forms.ToolStripButton SearchToolstripButton;
    }
}

