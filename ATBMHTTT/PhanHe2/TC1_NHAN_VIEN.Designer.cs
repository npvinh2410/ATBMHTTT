
namespace ATBMHTTT.PhanHe2
{
    partial class TC1_NHAN_VIEN
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridNhanVien = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnNVall = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(890, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 37);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Thêm";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GridNhanVien);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.btnNVall);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(27, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 378);
            this.panel1.TabIndex = 15;
            // 
            // GridNhanVien
            // 
            this.GridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNhanVien.Location = new System.Drawing.Point(40, 41);
            this.GridNhanVien.Name = "GridNhanVien";
            this.GridNhanVien.RowHeadersWidth = 51;
            this.GridNhanVien.RowTemplate.Height = 24;
            this.GridNhanVien.Size = new System.Drawing.Size(798, 300);
            this.GridNhanVien.TabIndex = 7;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(889, 52);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(88, 37);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnNVall
            // 
            this.btnNVall.Location = new System.Drawing.Point(889, 176);
            this.btnNVall.Name = "btnNVall";
            this.btnNVall.Size = new System.Drawing.Size(88, 64);
            this.btnNVall.TabIndex = 8;
            this.btnNVall.Text = "Tạo tất cả tài khoản nhân viên";
            this.btnNVall.UseVisualStyleBackColor = true;
            this.btnNVall.Click += new System.EventHandler(this.btnNVall_Click);
            // 
            // TC1_NHAN_VIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TC1_NHAN_VIEN";
            this.Text = "TC1_NHAN_VIEN";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridNhanVien;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnNVall;
    }
}