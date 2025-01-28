﻿using System.Collections.Generic;
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
            this.DpRadioBtn = new System.Windows.Forms.RadioButton();
            this.IDRadioBtn = new System.Windows.Forms.RadioButton();
            this.NameRadioBtn = new System.Windows.Forms.RadioButton();
            this.searchText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.SearchResultView.Location = new System.Drawing.Point(25, 66);
            this.SearchResultView.Name = "SearchResultView";
            this.SearchResultView.RowHeadersWidth = 62;
            this.SearchResultView.RowTemplate.Height = 30;
            this.SearchResultView.Size = new System.Drawing.Size(611, 377);
            this.SearchResultView.TabIndex = 0;
            // 
            // SeachOPGroup
            // 
            this.SeachOPGroup.Controls.Add(this.DpRadioBtn);
            this.SeachOPGroup.Controls.Add(this.IDRadioBtn);
            this.SeachOPGroup.Controls.Add(this.NameRadioBtn);
            this.SeachOPGroup.Location = new System.Drawing.Point(642, 66);
            this.SeachOPGroup.Name = "SeachOPGroup";
            this.SeachOPGroup.Size = new System.Drawing.Size(225, 158);
            this.SeachOPGroup.TabIndex = 3;
            this.SeachOPGroup.TabStop = false;
            this.SeachOPGroup.Text = "Select Search Option";
            // 
            // DpRadioBtn
            // 
            this.DpRadioBtn.AutoSize = true;
            this.DpRadioBtn.Location = new System.Drawing.Point(27, 113);
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
            this.IDRadioBtn.Location = new System.Drawing.Point(27, 75);
            this.IDRadioBtn.Name = "IDRadioBtn";
            this.IDRadioBtn.Size = new System.Drawing.Size(51, 22);
            this.IDRadioBtn.TabIndex = 5;
            this.IDRadioBtn.Text = "ID";
            this.IDRadioBtn.UseVisualStyleBackColor = true;
            this.IDRadioBtn.CheckedChanged += new System.EventHandler(this.IDRadioBtn_CheckedChanged);
            // 
            // NameRadioBtn
            // 
            this.NameRadioBtn.AutoSize = true;
            this.NameRadioBtn.Checked = true;
            this.NameRadioBtn.Location = new System.Drawing.Point(27, 37);
            this.NameRadioBtn.Name = "NameRadioBtn";
            this.NameRadioBtn.Size = new System.Drawing.Size(69, 22);
            this.NameRadioBtn.TabIndex = 4;
            this.NameRadioBtn.TabStop = true;
            this.NameRadioBtn.Text = "Name";
            this.NameRadioBtn.UseVisualStyleBackColor = true;
            this.NameRadioBtn.CheckedChanged += new System.EventHandler(this.NameRadioBtn_CheckedChanged);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(669, 240);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(183, 28);
            this.searchText.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.SeachOPGroup);
            this.Controls.Add(this.SearchResultView);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultView)).EndInit();
            this.SeachOPGroup.ResumeLayout(false);
            this.SeachOPGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView SearchResultView;
        private GroupBox SeachOPGroup;
        private RadioButton NameRadioBtn;
        private RadioButton DpRadioBtn;
        private RadioButton IDRadioBtn;
        private TextBox searchText;
        private Button button1;
    }
}