﻿using Oracle.ManagedDataAccess.Client;
namespace ATBMHTTT
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.privilegesGridView = new System.Windows.Forms.DataGridView();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.viewPrivilegesBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1050, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.privilegesGridView);
            this.tabPage2.Controls.Add(this.userNameTextBox);
            this.tabPage2.Controls.Add(this.roleNameTextBox);
            this.tabPage2.Controls.Add(this.viewPrivilegesBtn);
            this.tabPage2.Controls.Add(this.userNameLabel);
            this.tabPage2.Controls.Add(this.roleNameLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1050, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin quyền user/role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thêm user";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm Role";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // privilegesGridView
            // 
            this.privilegesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.privilegesGridView.Location = new System.Drawing.Point(36, 185);
            this.privilegesGridView.Name = "privilegesGridView";
            this.privilegesGridView.RowHeadersWidth = 51;
            this.privilegesGridView.RowTemplate.Height = 24;
            this.privilegesGridView.Size = new System.Drawing.Size(920, 385);
            this.privilegesGridView.TabIndex = 5;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(544, 44);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(225, 30);
            this.userNameTextBox.TabIndex = 4;
            // 
            // roleNameTextBox
            // 
            this.roleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameTextBox.Location = new System.Drawing.Point(121, 42);
            this.roleNameTextBox.Name = "roleNameTextBox";
            this.roleNameTextBox.Size = new System.Drawing.Size(225, 30);
            this.roleNameTextBox.TabIndex = 3;
            // 
            // viewPrivilegesBtn
            // 
            this.viewPrivilegesBtn.Location = new System.Drawing.Point(861, 45);
            this.viewPrivilegesBtn.Name = "viewPrivilegesBtn";
            this.viewPrivilegesBtn.Size = new System.Drawing.Size(95, 30);
            this.viewPrivilegesBtn.TabIndex = 2;
            this.viewPrivilegesBtn.Text = "Xem";
            this.viewPrivilegesBtn.UseVisualStyleBackColor = true;
            this.viewPrivilegesBtn.Click += new System.EventHandler(this.viewPrivilegesBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(448, 47);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(90, 25);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Tên user";
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameLabel.Location = new System.Drawing.Point(31, 47);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(84, 25);
            this.roleNameLabel.TabIndex = 0;
            this.roleNameLabel.Text = "Tên role";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1050, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1050, 622);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1061, 653);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button viewPrivilegesBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label roleNameLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.DataGridView privilegesGridView;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

