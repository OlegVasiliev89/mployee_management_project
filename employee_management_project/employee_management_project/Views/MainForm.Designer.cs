namespace employee_management_project
{
    partial class MainForm
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
      this.openEmployeeFormBtn = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.exportCSVButton = new System.Windows.Forms.Button();
      this.delSelectionButton = new System.Windows.Forms.Button();
      this.exportCSVTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // openEmployeeFormBtn
      // 
      this.openEmployeeFormBtn.Location = new System.Drawing.Point(16, 351);
      this.openEmployeeFormBtn.Name = "openEmployeeFormBtn";
      this.openEmployeeFormBtn.Size = new System.Drawing.Size(138, 23);
      this.openEmployeeFormBtn.TabIndex = 2;
      this.openEmployeeFormBtn.Text = "Open";
      this.openEmployeeFormBtn.UseVisualStyleBackColor = true;
      this.openEmployeeFormBtn.Click += new System.EventHandler(this.openEmployeeFormBtn_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 65);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(643, 241);
      this.dataGridView1.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(169, 350);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(138, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Search";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // exportCSVButton
      // 
      this.exportCSVButton.Location = new System.Drawing.Point(198, 410);
      this.exportCSVButton.Name = "exportCSVButton";
      this.exportCSVButton.Size = new System.Drawing.Size(69, 23);
      this.exportCSVButton.TabIndex = 5;
      this.exportCSVButton.Text = "Export CSV";
      this.exportCSVButton.UseVisualStyleBackColor = true;
      this.exportCSVButton.Click += new System.EventHandler(this.exportCSVButton_Click_1);
      // 
      // delSelectionButton
      // 
      this.delSelectionButton.Location = new System.Drawing.Point(328, 350);
      this.delSelectionButton.Name = "delSelectionButton";
      this.delSelectionButton.Size = new System.Drawing.Size(138, 23);
      this.delSelectionButton.TabIndex = 7;
      this.delSelectionButton.Text = "Delete Selection";
      this.delSelectionButton.UseVisualStyleBackColor = true;
      this.delSelectionButton.Click += new System.EventHandler(this.delSelectionButton_Click);
      // 
      // exportCSVTextBox
      // 
      this.exportCSVTextBox.Location = new System.Drawing.Point(16, 410);
      this.exportCSVTextBox.Name = "exportCSVTextBox";
      this.exportCSVTextBox.Size = new System.Drawing.Size(176, 20);
      this.exportCSVTextBox.TabIndex = 8;
      this.exportCSVTextBox.Tag = "";
      this.exportCSVTextBox.Text = "Type file path";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(123, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(392, 29);
      this.label1.TabIndex = 9;
      this.label1.Text = "Employee Management Dashboard";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(161)))), ((int)(((byte)(238)))));
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 11);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(643, 48);
      this.panel1.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 326);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(147, 20);
      this.label2.TabIndex = 11;
      this.label2.Text = "Add New Employee";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(165, 326);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(134, 20);
      this.label3.TabIndex = 12;
      this.label3.Text = "Search Employee";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 387);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 20);
      this.label4.TabIndex = 13;
      this.label4.Text = "Export";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(324, 326);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(197, 20);
      this.label5.TabIndex = 14;
      this.label5.Text = "Delete Selected Employee";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(671, 454);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.exportCSVTextBox);
      this.Controls.Add(this.delSelectionButton);
      this.Controls.Add(this.exportCSVButton);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.openEmployeeFormBtn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
    private System.Windows.Forms.Button openEmployeeFormBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportCSVButton;
        private System.Windows.Forms.Button delSelectionButton;
    private System.Windows.Forms.TextBox exportCSVTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
  }
}

