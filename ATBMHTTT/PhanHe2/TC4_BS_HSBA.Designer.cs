﻿namespace ATBMHTTT.PhanHe2
{
    partial class TC4_BS_HSBA
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
            this.dataGridViewHSBA = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewBN = new System.Windows.Forms.DataGridView();
            this.btnTimKiemBN = new System.Windows.Forms.Button();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XemTT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBN)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewHSBA);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnTimKiem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hồ Sơ Bệnh Án/Dịch Vụ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHSBA
            // 
            this.dataGridViewHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHSBA.Location = new System.Drawing.Point(47, 130);
            this.dataGridViewHSBA.Name = "dataGridViewHSBA";
            this.dataGridViewHSBA.RowHeadersWidth = 51;
            this.dataGridViewHSBA.RowTemplate.Height = 24;
            this.dataGridViewHSBA.Size = new System.Drawing.Size(659, 218);
            this.dataGridViewHSBA.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(399, 72);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(134, 38);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Xem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC HỒ SƠ BỆNH ÁN/DỊCH VỤ ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewBN);
            this.tabPage2.Controls.Add(this.btnTimKiemBN);
            this.tabPage2.Controls.Add(this.txtMaBN);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bệnh Nhân";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBN
            // 
            this.dataGridViewBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBN.Location = new System.Drawing.Point(24, 146);
            this.dataGridViewBN.Name = "dataGridViewBN";
            this.dataGridViewBN.RowHeadersWidth = 51;
            this.dataGridViewBN.RowTemplate.Height = 24;
            this.dataGridViewBN.Size = new System.Drawing.Size(698, 140);
            this.dataGridViewBN.TabIndex = 4;
            // 
            // btnTimKiemBN
            // 
            this.btnTimKiemBN.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemBN.Location = new System.Drawing.Point(587, 67);
            this.btnTimKiemBN.Name = "btnTimKiemBN";
            this.btnTimKiemBN.Size = new System.Drawing.Size(119, 33);
            this.btnTimKiemBN.TabIndex = 3;
            this.btnTimKiemBN.Text = "Tìm Kiếm";
            this.btnTimKiemBN.UseVisualStyleBackColor = true;
            this.btnTimKiemBN.Click += new System.EventHandler(this.btnTimKiemBN_Click);
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(308, 73);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(232, 22);
            this.txtMaBN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập mã/ CMND bệnh nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH BỆNH NHÂN TẠI CSYT";
            // 
            // XemTT
            // 
            this.XemTT.AutoSize = true;
            this.XemTT.Location = new System.Drawing.Point(616, 13);
            this.XemTT.Margin = new System.Windows.Forms.Padding(4);
            this.XemTT.Name = "XemTT";
            this.XemTT.Size = new System.Drawing.Size(139, 36);
            this.XemTT.TabIndex = 6;
            this.XemTT.Text = "Thông tin cá nhân";
            this.XemTT.UseVisualStyleBackColor = true;
            this.XemTT.Click += new System.EventHandler(this.XemTT_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Chi Tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TC4_BS_HSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 457);
            this.Controls.Add(this.XemTT);
            this.Controls.Add(this.tabControl1);
            this.Name = "TC4_BS_HSBA";
            this.Text = "TC4_BS_HSBA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSBA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewHSBA;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewBN;
        private System.Windows.Forms.Button btnTimKiemBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button XemTT;
        private System.Windows.Forms.Button button1;
    }
}