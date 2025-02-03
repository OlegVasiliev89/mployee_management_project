using System.Collections.Generic;
using System.Windows.Forms;

namespace employee_management_project
{
    partial class SearchForm
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
            this.SearchResultView = new System.Windows.Forms.DataGridView();
            this.SeachOPGroup = new System.Windows.Forms.GroupBox();
            this.AgeRadioBtn = new System.Windows.Forms.RadioButton();
            this.SalaryRadioBtn = new System.Windows.Forms.RadioButton();
            this.LNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.DpRadioBtn = new System.Windows.Forms.RadioButton();
            this.IDRadioBtn = new System.Windows.Forms.RadioButton();
            this.FNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.searchText = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.departmentDropdownMenu = new System.Windows.Forms.ComboBox();
            this.PRBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultView)).BeginInit();
            this.SeachOPGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchResultView
            // 
            this.SearchResultView.AllowUserToAddRows = false;
            this.SearchResultView.AllowUserToDeleteRows = false;
            this.SearchResultView.AllowUserToResizeColumns = false;
            this.SearchResultView.AllowUserToResizeRows = false;
            this.SearchResultView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultView.Location = new System.Drawing.Point(26, 66);
            this.SearchResultView.Name = "SearchResultView";
            this.SearchResultView.RowHeadersWidth = 62;
            this.SearchResultView.RowTemplate.Height = 30;
            this.SearchResultView.Size = new System.Drawing.Size(610, 377);
            this.SearchResultView.TabIndex = 0;
            // 
            // SeachOPGroup
            // 
            this.SeachOPGroup.Controls.Add(this.AgeRadioBtn);
            this.SeachOPGroup.Controls.Add(this.SalaryRadioBtn);
            this.SeachOPGroup.Controls.Add(this.LNameRadioBtn);
            this.SeachOPGroup.Controls.Add(this.DpRadioBtn);
            this.SeachOPGroup.Controls.Add(this.IDRadioBtn);
            this.SeachOPGroup.Controls.Add(this.FNameRadioBtn);
            this.SeachOPGroup.Location = new System.Drawing.Point(642, 66);
            this.SeachOPGroup.Name = "SeachOPGroup";
            this.SeachOPGroup.Size = new System.Drawing.Size(225, 282);
            this.SeachOPGroup.TabIndex = 3;
            this.SeachOPGroup.TabStop = false;
            this.SeachOPGroup.Text = "Select Search Option";
            // 
            // AgeRadioBtn
            // 
            this.AgeRadioBtn.AutoSize = true;
            this.AgeRadioBtn.Location = new System.Drawing.Point(27, 236);
            this.AgeRadioBtn.Name = "AgeRadioBtn";
            this.AgeRadioBtn.Size = new System.Drawing.Size(60, 22);
            this.AgeRadioBtn.TabIndex = 9;
            this.AgeRadioBtn.Text = "Age";
            this.AgeRadioBtn.UseVisualStyleBackColor = true;
            this.AgeRadioBtn.CheckedChanged += new System.EventHandler(this.AgeRadioBtn_CheckedChanged);
            // 
            // SalaryRadioBtn
            // 
            this.SalaryRadioBtn.AutoSize = true;
            this.SalaryRadioBtn.Location = new System.Drawing.Point(27, 195);
            this.SalaryRadioBtn.Name = "SalaryRadioBtn";
            this.SalaryRadioBtn.Size = new System.Drawing.Size(87, 22);
            this.SalaryRadioBtn.TabIndex = 8;
            this.SalaryRadioBtn.Text = "Salary";
            this.SalaryRadioBtn.UseVisualStyleBackColor = true;
            this.SalaryRadioBtn.CheckedChanged += new System.EventHandler(this.SalaryRadioBtn_CheckedChanged);
            // 
            // LNameRadioBtn
            // 
            this.LNameRadioBtn.AutoSize = true;
            this.LNameRadioBtn.Location = new System.Drawing.Point(27, 113);
            this.LNameRadioBtn.Name = "LNameRadioBtn";
            this.LNameRadioBtn.Size = new System.Drawing.Size(114, 22);
            this.LNameRadioBtn.TabIndex = 7;
            this.LNameRadioBtn.Text = "Last Name";
            this.LNameRadioBtn.UseVisualStyleBackColor = true;
            this.LNameRadioBtn.CheckedChanged += new System.EventHandler(this.LNameRadioBtn_CheckedChanged);
            // 
            // DpRadioBtn
            // 
            this.DpRadioBtn.AutoSize = true;
            this.DpRadioBtn.Location = new System.Drawing.Point(27, 151);
            this.DpRadioBtn.Name = "DpRadioBtn";
            this.DpRadioBtn.Size = new System.Drawing.Size(123, 22);
            this.DpRadioBtn.TabIndex = 6;
            this.DpRadioBtn.Text = "Department";
            this.DpRadioBtn.UseVisualStyleBackColor = true;
            this.DpRadioBtn.CheckedChanged += new System.EventHandler(this.DpRadioBtn_CheckedChanged);
            // 
            // IDRadioBtn
            // 
            this.IDRadioBtn.AutoSize = true;
            this.IDRadioBtn.Location = new System.Drawing.Point(27, 36);
            this.IDRadioBtn.Name = "IDRadioBtn";
            this.IDRadioBtn.Size = new System.Drawing.Size(51, 22);
            this.IDRadioBtn.TabIndex = 5;
            this.IDRadioBtn.Text = "ID";
            this.IDRadioBtn.UseVisualStyleBackColor = true;
            this.IDRadioBtn.CheckedChanged += new System.EventHandler(this.IDRadioBtn_CheckedChanged);
            // 
            // FNameRadioBtn
            // 
            this.FNameRadioBtn.AutoSize = true;
            this.FNameRadioBtn.Checked = true;
            this.FNameRadioBtn.Location = new System.Drawing.Point(27, 73);
            this.FNameRadioBtn.Name = "FNameRadioBtn";
            this.FNameRadioBtn.Size = new System.Drawing.Size(123, 22);
            this.FNameRadioBtn.TabIndex = 4;
            this.FNameRadioBtn.TabStop = true;
            this.FNameRadioBtn.Text = "First Name";
            this.FNameRadioBtn.UseVisualStyleBackColor = true;
            this.FNameRadioBtn.CheckedChanged += new System.EventHandler(this.FNameRadioBtn_CheckedChanged);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(669, 367);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(182, 28);
            this.searchText.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(717, 414);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 36);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // departmentDropdownMenu
            // 
            this.departmentDropdownMenu.FormattingEnabled = true;
            this.departmentDropdownMenu.Items.AddRange(new object[] {
            "Human Resource",
            "Customer Care",
            "Finance",
            "IT",
            "Product Engineering",
            "Executive Member"});
            this.departmentDropdownMenu.Location = new System.Drawing.Point(669, 369);
            this.departmentDropdownMenu.Margin = new System.Windows.Forms.Padding(4);
            this.departmentDropdownMenu.Name = "departmentDropdownMenu";
            this.departmentDropdownMenu.Size = new System.Drawing.Size(182, 26);
            this.departmentDropdownMenu.TabIndex = 6;
            this.departmentDropdownMenu.Text = "Select Department";
            this.departmentDropdownMenu.Visible = false;
            // 
            // PRBtn
            // 
            this.PRBtn.Location = new System.Drawing.Point(41, 471);
            this.PRBtn.Name = "PRBtn";
            this.PRBtn.Size = new System.Drawing.Size(138, 35);
            this.PRBtn.TabIndex = 7;
            this.PRBtn.Text = "Push Result";
            this.PRBtn.UseVisualStyleBackColor = true;
            this.PRBtn.Click += new System.EventHandler(this.PRBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 564);
            this.Controls.Add(this.PRBtn);
            this.Controls.Add(this.departmentDropdownMenu);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.SeachOPGroup);
            this.Controls.Add(this.SearchResultView);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultView)).EndInit();
            this.SeachOPGroup.ResumeLayout(false);
            this.SeachOPGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView SearchResultView;
        private GroupBox SeachOPGroup;
        private RadioButton FNameRadioBtn;
        private RadioButton DpRadioBtn;
        private RadioButton IDRadioBtn;
        private TextBox searchText;
        private Button SearchBtn;
        private RadioButton LNameRadioBtn;
        private RadioButton AgeRadioBtn;
        private RadioButton SalaryRadioBtn;
        private ComboBox departmentDropdownMenu;
        private Button PRBtn;
    }
}