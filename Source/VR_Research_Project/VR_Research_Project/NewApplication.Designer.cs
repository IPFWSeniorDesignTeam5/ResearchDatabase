﻿namespace VR_Research_Project
{
    partial class NewApplication
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.researchDatabaseDataSet = new VR_Research_Project.ResearchDatabaseDataSet();
            this.developerTableAdapter = new VR_Research_Project.ResearchDatabaseDataSetTableAdapters.DeveloperTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.DeveloperCombobox = new System.Windows.Forms.ComboBox();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(240, 164);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(115, 28);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKClicked);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(363, 164);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 28);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelClicked);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(75, 38);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextbox.MaxLength = 250;
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(391, 22);
            this.NameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // researchDatabaseDataSet
            // 
            this.researchDatabaseDataSet.DataSetName = "ResearchDatabaseDataSet";
            this.researchDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // developerTableAdapter
            // 
            this.developerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Developer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ErrorText
            // 
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorText.Location = new System.Drawing.Point(20, 144);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(457, 20);
            this.ErrorText.TabIndex = 6;
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeveloperCombobox
            // 
            this.DeveloperCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DeveloperCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.researchDatabaseDataSet, "Developer.Id", true));
            this.DeveloperCombobox.DataSource = this.researchDatabaseDataSet;
            this.DeveloperCombobox.DisplayMember = "Developer.Name";
            this.DeveloperCombobox.FormattingEnabled = true;
            this.DeveloperCombobox.Location = new System.Drawing.Point(20, 101);
            this.DeveloperCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.DeveloperCombobox.MaxLength = 250;
            this.DeveloperCombobox.Name = "DeveloperCombobox";
            this.DeveloperCombobox.Size = new System.Drawing.Size(280, 24);
            this.DeveloperCombobox.TabIndex = 1;
            this.DeveloperCombobox.ValueMember = "Developer.Id";
            // 
            // releaseDate
            // 
            this.releaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.releaseDate.Location = new System.Drawing.Point(323, 101);
            this.releaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(143, 22);
            this.releaseDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(323, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Release Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.DeveloperCombobox);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Application...";
            this.Load += new System.EventHandler(this.NewApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.researchDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label1;
        private ResearchDatabaseDataSet researchDatabaseDataSet;
        private ResearchDatabaseDataSetTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.ComboBox DeveloperCombobox;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.Label label3;
    }
}