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
      this.SearchResultView.Location = new System.Drawing.Point(17, 48);
      this.SearchResultView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.SearchResultView.Name = "SearchResultView";
      this.SearchResultView.RowHeadersWidth = 62;
      this.SearchResultView.RowTemplate.Height = 30;
      this.SearchResultView.Size = new System.Drawing.Size(407, 272);
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
      this.SeachOPGroup.Location = new System.Drawing.Point(428, 48);
      this.SeachOPGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.SeachOPGroup.Name = "SeachOPGroup";
      this.SeachOPGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.SeachOPGroup.Size = new System.Drawing.Size(150, 204);
      this.SeachOPGroup.TabIndex = 3;
      this.SeachOPGroup.TabStop = false;
      this.SeachOPGroup.Text = "Select Search Option";
      // 
      // AgeRadioBtn
      // 
      this.AgeRadioBtn.AutoSize = true;
      this.AgeRadioBtn.Location = new System.Drawing.Point(18, 170);
      this.AgeRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.AgeRadioBtn.Name = "AgeRadioBtn";
      this.AgeRadioBtn.Size = new System.Drawing.Size(44, 17);
      this.AgeRadioBtn.TabIndex = 9;
      this.AgeRadioBtn.Text = "Age";
      this.AgeRadioBtn.UseVisualStyleBackColor = true;
      this.AgeRadioBtn.CheckedChanged += new System.EventHandler(this.AgeRadioBtn_CheckedChanged);
      // 
      // SalaryRadioBtn
      // 
      this.SalaryRadioBtn.AutoSize = true;
      this.SalaryRadioBtn.Location = new System.Drawing.Point(18, 141);
      this.SalaryRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.SalaryRadioBtn.Name = "SalaryRadioBtn";
      this.SalaryRadioBtn.Size = new System.Drawing.Size(54, 17);
      this.SalaryRadioBtn.TabIndex = 8;
      this.SalaryRadioBtn.Text = "Salary";
      this.SalaryRadioBtn.UseVisualStyleBackColor = true;
      this.SalaryRadioBtn.CheckedChanged += new System.EventHandler(this.SalaryRadioBtn_CheckedChanged);
      // 
      // LNameRadioBtn
      // 
      this.LNameRadioBtn.AutoSize = true;
      this.LNameRadioBtn.Location = new System.Drawing.Point(18, 82);
      this.LNameRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.LNameRadioBtn.Name = "LNameRadioBtn";
      this.LNameRadioBtn.Size = new System.Drawing.Size(76, 17);
      this.LNameRadioBtn.TabIndex = 7;
      this.LNameRadioBtn.Text = "Last Name";
      this.LNameRadioBtn.UseVisualStyleBackColor = true;
      this.LNameRadioBtn.CheckedChanged += new System.EventHandler(this.LNameRadioBtn_CheckedChanged);
      // 
      // DpRadioBtn
      // 
      this.DpRadioBtn.AutoSize = true;
      this.DpRadioBtn.Location = new System.Drawing.Point(18, 109);
      this.DpRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.DpRadioBtn.Name = "DpRadioBtn";
      this.DpRadioBtn.Size = new System.Drawing.Size(80, 17);
      this.DpRadioBtn.TabIndex = 6;
      this.DpRadioBtn.Text = "Department";
      this.DpRadioBtn.UseVisualStyleBackColor = true;
      this.DpRadioBtn.CheckedChanged += new System.EventHandler(this.DpRadioBtn_CheckedChanged);
      // 
      // IDRadioBtn
      // 
      this.IDRadioBtn.AutoSize = true;
      this.IDRadioBtn.Location = new System.Drawing.Point(18, 26);
      this.IDRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.IDRadioBtn.Name = "IDRadioBtn";
      this.IDRadioBtn.Size = new System.Drawing.Size(36, 17);
      this.IDRadioBtn.TabIndex = 5;
      this.IDRadioBtn.Text = "ID";
      this.IDRadioBtn.UseVisualStyleBackColor = true;
      this.IDRadioBtn.CheckedChanged += new System.EventHandler(this.IDRadioBtn_CheckedChanged);
      // 
      // FNameRadioBtn
      // 
      this.FNameRadioBtn.AutoSize = true;
      this.FNameRadioBtn.Checked = true;
      this.FNameRadioBtn.Location = new System.Drawing.Point(18, 53);
      this.FNameRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.FNameRadioBtn.Name = "FNameRadioBtn";
      this.FNameRadioBtn.Size = new System.Drawing.Size(75, 17);
      this.FNameRadioBtn.TabIndex = 4;
      this.FNameRadioBtn.TabStop = true;
      this.FNameRadioBtn.Text = "First Name";
      this.FNameRadioBtn.UseVisualStyleBackColor = true;
      this.FNameRadioBtn.CheckedChanged += new System.EventHandler(this.FNameRadioBtn_CheckedChanged);
      // 
      // searchText
      // 
      this.searchText.Location = new System.Drawing.Point(446, 265);
      this.searchText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.searchText.Name = "searchText";
      this.searchText.Size = new System.Drawing.Size(123, 20);
      this.searchText.TabIndex = 4;
      // 
      // SearchBtn
      // 
      this.SearchBtn.Location = new System.Drawing.Point(478, 299);
      this.SearchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.SearchBtn.Name = "SearchBtn";
      this.SearchBtn.Size = new System.Drawing.Size(50, 26);
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
      this.departmentDropdownMenu.Location = new System.Drawing.Point(446, 266);
      this.departmentDropdownMenu.Name = "departmentDropdownMenu";
      this.departmentDropdownMenu.Size = new System.Drawing.Size(123, 21);
      this.departmentDropdownMenu.TabIndex = 6;
      this.departmentDropdownMenu.Text = "Select Department";
      this.departmentDropdownMenu.Visible = false;
      // 
      // PRBtn
      // 
      this.PRBtn.Location = new System.Drawing.Point(27, 340);
      this.PRBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.PRBtn.Name = "PRBtn";
      this.PRBtn.Size = new System.Drawing.Size(92, 25);
      this.PRBtn.TabIndex = 7;
      this.PRBtn.Text = "Push Result";
      this.PRBtn.UseVisualStyleBackColor = true;
      this.PRBtn.Click += new System.EventHandler(this.PRBtn_Click);
      // 
      // SearchForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(599, 407);
      this.Controls.Add(this.PRBtn);
      this.Controls.Add(this.departmentDropdownMenu);
      this.Controls.Add(this.SearchBtn);
      this.Controls.Add(this.searchText);
      this.Controls.Add(this.SeachOPGroup);
      this.Controls.Add(this.SearchResultView);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "SearchForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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