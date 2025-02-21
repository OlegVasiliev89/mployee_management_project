namespace employee_management_project.Views {
  partial class LoginForm {
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
      this.usernameLabel = new System.Windows.Forms.Label();
      this.usernameInputBox = new System.Windows.Forms.TextBox();
      this.passwordInputBox = new System.Windows.Forms.TextBox();
      this.passwordLabel = new System.Windows.Forms.Label();
      this.loginBtn = new System.Windows.Forms.Button();
      this.quitBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // usernameLabel
      // 
      this.usernameLabel.AutoSize = true;
      this.usernameLabel.Location = new System.Drawing.Point(223, 133);
      this.usernameLabel.Name = "usernameLabel";
      this.usernameLabel.Size = new System.Drawing.Size(55, 13);
      this.usernameLabel.TabIndex = 0;
      this.usernameLabel.Text = "Username";
      // 
      // usernameInputBox
      // 
      this.usernameInputBox.Location = new System.Drawing.Point(284, 133);
      this.usernameInputBox.Name = "usernameInputBox";
      this.usernameInputBox.Size = new System.Drawing.Size(176, 20);
      this.usernameInputBox.TabIndex = 1;
      // 
      // passwordInputBox
      // 
      this.passwordInputBox.Location = new System.Drawing.Point(284, 195);
      this.passwordInputBox.Name = "passwordInputBox";
      this.passwordInputBox.Size = new System.Drawing.Size(176, 20);
      this.passwordInputBox.TabIndex = 2;
      // 
      // passwordLabel
      // 
      this.passwordLabel.AutoSize = true;
      this.passwordLabel.Location = new System.Drawing.Point(223, 195);
      this.passwordLabel.Name = "passwordLabel";
      this.passwordLabel.Size = new System.Drawing.Size(53, 13);
      this.passwordLabel.TabIndex = 3;
      this.passwordLabel.Text = "Password";
      // 
      // loginBtn
      // 
      this.loginBtn.Location = new System.Drawing.Point(226, 256);
      this.loginBtn.Name = "loginBtn";
      this.loginBtn.Size = new System.Drawing.Size(75, 23);
      this.loginBtn.TabIndex = 4;
      this.loginBtn.Text = "Login";
      this.loginBtn.UseVisualStyleBackColor = true;
      // 
      // quitBtn
      // 
      this.quitBtn.Location = new System.Drawing.Point(385, 256);
      this.quitBtn.Name = "quitBtn";
      this.quitBtn.Size = new System.Drawing.Size(75, 23);
      this.quitBtn.TabIndex = 5;
      this.quitBtn.Text = "Quit";
      this.quitBtn.UseVisualStyleBackColor = true;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.quitBtn);
      this.Controls.Add(this.loginBtn);
      this.Controls.Add(this.passwordLabel);
      this.Controls.Add(this.passwordInputBox);
      this.Controls.Add(this.usernameInputBox);
      this.Controls.Add(this.usernameLabel);
      this.Name = "LoginForm";
      this.Text = "LoginForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label usernameLabel;
    private System.Windows.Forms.TextBox usernameInputBox;
    private System.Windows.Forms.TextBox passwordInputBox;
    private System.Windows.Forms.Label passwordLabel;
    private System.Windows.Forms.Button loginBtn;
    private System.Windows.Forms.Button quitBtn;
  }
}