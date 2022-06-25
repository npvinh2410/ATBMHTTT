
namespace ATBMHTTT.PhanHe2
{
    partial class TC1_CSYT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridCSYT = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sdt = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.maCSYT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCSYT)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ CƠ SỞ Y TẾ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GridCSYT);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Location = new System.Drawing.Point(41, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 378);
            this.panel1.TabIndex = 13;
            // 
            // GridCSYT
            // 
            this.GridCSYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCSYT.Location = new System.Drawing.Point(147, 37);
            this.GridCSYT.Name = "GridCSYT";
            this.GridCSYT.RowHeadersWidth = 51;
            this.GridCSYT.RowTemplate.Height = 24;
            this.GridCSYT.Size = new System.Drawing.Size(464, 300);
            this.GridCSYT.TabIndex = 7;
            this.GridCSYT.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridCSYT_MouseDoubleClick);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(19, 49);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(88, 37);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(19, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 37);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sdt);
            this.panel2.Controls.Add(this.diachi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ten);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.maCSYT);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(750, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 378);
            this.panel2.TabIndex = 14;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(116, 226);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(213, 22);
            this.sdt.TabIndex = 32;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(116, 181);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(213, 22);
            this.diachi.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Sđt:";
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(116, 139);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(213, 22);
            this.ten.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Địa chỉ:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(241, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 37);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tên:";
            // 
            // maCSYT
            // 
            this.maCSYT.Location = new System.Drawing.Point(116, 90);
            this.maCSYT.Name = "maCSYT";
            this.maCSYT.ReadOnly = true;
            this.maCSYT.Size = new System.Drawing.Size(213, 22);
            this.maCSYT.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mã CSYT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thông tin chi tiết";
            // 
            // TC1_CSYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TC1_CSYT";
            this.Text = "TC1_CSYT";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCSYT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridCSYT;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maCSYT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}