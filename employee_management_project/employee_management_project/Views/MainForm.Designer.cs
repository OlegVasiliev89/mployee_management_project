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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delSelectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openEmployeeFormBtn
            // 
            this.openEmployeeFormBtn.Location = new System.Drawing.Point(125, 320);
            this.openEmployeeFormBtn.Name = "openEmployeeFormBtn";
            this.openEmployeeFormBtn.Size = new System.Drawing.Size(138, 23);
            this.openEmployeeFormBtn.TabIndex = 2;
            this.openEmployeeFormBtn.Text = "Open Employee Form";
            this.openEmployeeFormBtn.UseVisualStyleBackColor = true;
            this.openEmployeeFormBtn.Click += new System.EventHandler(this.openEmployeeFormBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 246);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportCSVButton
            // 
            this.exportCSVButton.Location = new System.Drawing.Point(625, 117);
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(138, 23);
            this.exportCSVButton.TabIndex = 5;
            this.exportCSVButton.Text = "Export CSV";
            this.exportCSVButton.UseVisualStyleBackColor = true;
            this.exportCSVButton.Click += new System.EventHandler(this.exportCSVButton_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(625, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 6;
            // 
            // delSelectionButton
            // 
            this.delSelectionButton.Location = new System.Drawing.Point(625, 253);
            this.delSelectionButton.Name = "delSelectionButton";
            this.delSelectionButton.Size = new System.Drawing.Size(138, 23);
            this.delSelectionButton.TabIndex = 7;
            this.delSelectionButton.Text = "Delete Selection";
            this.delSelectionButton.UseVisualStyleBackColor = true;
            this.delSelectionButton.Click += new System.EventHandler(this.delSelectionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delSelectionButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exportCSVButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.openEmployeeFormBtn);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    private System.Windows.Forms.Button openEmployeeFormBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportCSVButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button delSelectionButton;
    }
}

