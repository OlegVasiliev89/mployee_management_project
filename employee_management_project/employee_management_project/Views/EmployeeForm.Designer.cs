namespace employee_management_project.Views {
  partial class EmployeeForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.employeeFormListBox = new System.Windows.Forms.ListBox();
      this.addEmployeeBtn = new System.Windows.Forms.Button();
      this.closeEmployeeFormBtn = new System.Windows.Forms.Button();
      this.departmentDropdownMenu = new System.Windows.Forms.ComboBox();
      this.idInputBox = new System.Windows.Forms.TextBox();
      this.salaryInputBox = new System.Windows.Forms.TextBox();
      this.firstNameInputBox = new System.Windows.Forms.TextBox();
      this.lastNameInputBox = new System.Windows.Forms.TextBox();
      this.ageInputBox = new System.Windows.Forms.TextBox();
      this.idLabel = new System.Windows.Forms.Label();
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.departmentLabel = new System.Windows.Forms.Label();
      this.ageLabel = new System.Windows.Forms.Label();
      this.salaryLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // employeeFormListBox
      // 
      this.employeeFormListBox.FormattingEnabled = true;
      this.employeeFormListBox.Location = new System.Drawing.Point(13, 13);
      this.employeeFormListBox.Name = "employeeFormListBox";
      this.employeeFormListBox.Size = new System.Drawing.Size(292, 212);
      this.employeeFormListBox.TabIndex = 0;
      // 
      // addEmployeeBtn
      // 
      this.addEmployeeBtn.Location = new System.Drawing.Point(13, 244);
      this.addEmployeeBtn.Name = "addEmployeeBtn";
      this.addEmployeeBtn.Size = new System.Drawing.Size(101, 23);
      this.addEmployeeBtn.TabIndex = 1;
      this.addEmployeeBtn.Text = "Add Employee";
      this.addEmployeeBtn.UseVisualStyleBackColor = true;
      this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
      // 
      // closeEmployeeFormBtn
      // 
      this.closeEmployeeFormBtn.Location = new System.Drawing.Point(195, 244);
      this.closeEmployeeFormBtn.Name = "closeEmployeeFormBtn";
      this.closeEmployeeFormBtn.Size = new System.Drawing.Size(110, 23);
      this.closeEmployeeFormBtn.TabIndex = 2;
      this.closeEmployeeFormBtn.Text = "Close";
      this.closeEmployeeFormBtn.UseVisualStyleBackColor = true;
      this.closeEmployeeFormBtn.Click += new System.EventHandler(this.closeEmployeeFormBtn_Click);
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
      this.departmentDropdownMenu.Location = new System.Drawing.Point(122, 120);
      this.departmentDropdownMenu.Name = "departmentDropdownMenu";
      this.departmentDropdownMenu.Size = new System.Drawing.Size(167, 21);
      this.departmentDropdownMenu.TabIndex = 3;
      this.departmentDropdownMenu.Text = "Select Department";
      this.departmentDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.departmentDropdownMenu_SelectedIndexChanged);
      // 
      // idInputBox
      // 
      this.idInputBox.Location = new System.Drawing.Point(122, 42);
      this.idInputBox.Name = "idInputBox";
      this.idInputBox.Size = new System.Drawing.Size(167, 20);
      this.idInputBox.TabIndex = 4;
      this.idInputBox.TextChanged += new System.EventHandler(this.idInputBox_TextChanged);
      // 
      // salaryInputBox
      // 
      this.salaryInputBox.Location = new System.Drawing.Point(122, 147);
      this.salaryInputBox.Name = "salaryInputBox";
      this.salaryInputBox.Size = new System.Drawing.Size(167, 20);
      this.salaryInputBox.TabIndex = 5;
      this.salaryInputBox.TextChanged += new System.EventHandler(this.salaryInputBox_TextChanged);
      // 
      // firstNameInputBox
      // 
      this.firstNameInputBox.Location = new System.Drawing.Point(122, 68);
      this.firstNameInputBox.Name = "firstNameInputBox";
      this.firstNameInputBox.Size = new System.Drawing.Size(167, 20);
      this.firstNameInputBox.TabIndex = 5;
      this.firstNameInputBox.TextChanged += new System.EventHandler(this.firstNameInputBox_TextChanged);
      // 
      // lastNameInputBox
      // 
      this.lastNameInputBox.Location = new System.Drawing.Point(122, 94);
      this.lastNameInputBox.Name = "lastNameInputBox";
      this.lastNameInputBox.Size = new System.Drawing.Size(167, 20);
      this.lastNameInputBox.TabIndex = 6;
      this.lastNameInputBox.TextChanged += new System.EventHandler(this.lastNameInputBox_TextChanged);
      // 
      // ageInputBox
      // 
      this.ageInputBox.Location = new System.Drawing.Point(122, 173);
      this.ageInputBox.Name = "ageInputBox";
      this.ageInputBox.Size = new System.Drawing.Size(167, 20);
      this.ageInputBox.TabIndex = 7;
      this.ageInputBox.TextChanged += new System.EventHandler(this.ageInputBox_TextChanged);
      // 
      // idLabel
      // 
      this.idLabel.AutoSize = true;
      this.idLabel.Location = new System.Drawing.Point(24, 42);
      this.idLabel.Name = "idLabel";
      this.idLabel.Size = new System.Drawing.Size(18, 13);
      this.idLabel.TabIndex = 8;
      this.idLabel.Text = "ID";
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.Location = new System.Drawing.Point(24, 68);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
      this.firstNameLabel.TabIndex = 9;
      this.firstNameLabel.Text = "First Name";
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Location = new System.Drawing.Point(24, 94);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
      this.lastNameLabel.TabIndex = 10;
      this.lastNameLabel.Text = "Last Name";
      // 
      // departmentLabel
      // 
      this.departmentLabel.AutoSize = true;
      this.departmentLabel.Location = new System.Drawing.Point(24, 120);
      this.departmentLabel.Name = "departmentLabel";
      this.departmentLabel.Size = new System.Drawing.Size(62, 13);
      this.departmentLabel.TabIndex = 11;
      this.departmentLabel.Text = "Department";
      // 
      // ageLabel
      // 
      this.ageLabel.AutoSize = true;
      this.ageLabel.Location = new System.Drawing.Point(24, 173);
      this.ageLabel.Name = "ageLabel";
      this.ageLabel.Size = new System.Drawing.Size(26, 13);
      this.ageLabel.TabIndex = 12;
      this.ageLabel.Text = "Age";
      // 
      // salaryLabel
      // 
      this.salaryLabel.AutoSize = true;
      this.salaryLabel.Location = new System.Drawing.Point(24, 147);
      this.salaryLabel.Name = "salaryLabel";
      this.salaryLabel.Size = new System.Drawing.Size(36, 13);
      this.salaryLabel.TabIndex = 13;
      this.salaryLabel.Text = "Salary";
      // 
      // EmployeeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(317, 290);
      this.Controls.Add(this.salaryLabel);
      this.Controls.Add(this.ageLabel);
      this.Controls.Add(this.departmentLabel);
      this.Controls.Add(this.lastNameLabel);
      this.Controls.Add(this.firstNameLabel);
      this.Controls.Add(this.idLabel);
      this.Controls.Add(this.ageInputBox);
      this.Controls.Add(this.lastNameInputBox);
      this.Controls.Add(this.firstNameInputBox);
      this.Controls.Add(this.salaryInputBox);
      this.Controls.Add(this.idInputBox);
      this.Controls.Add(this.departmentDropdownMenu);
      this.Controls.Add(this.closeEmployeeFormBtn);
      this.Controls.Add(this.addEmployeeBtn);
      this.Controls.Add(this.employeeFormListBox);
      this.Name = "EmployeeForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "EmployeeForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox employeeFormListBox;
    private System.Windows.Forms.Button addEmployeeBtn;
    private System.Windows.Forms.Button closeEmployeeFormBtn;
    private System.Windows.Forms.ComboBox departmentDropdownMenu;
    private System.Windows.Forms.TextBox idInputBox;
    private System.Windows.Forms.TextBox salaryInputBox;
    private System.Windows.Forms.TextBox firstNameInputBox;
    private System.Windows.Forms.TextBox lastNameInputBox;
    private System.Windows.Forms.TextBox ageInputBox;
    private System.Windows.Forms.Label idLabel;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.Label departmentLabel;
    private System.Windows.Forms.Label ageLabel;
    private System.Windows.Forms.Label salaryLabel;
  }
}