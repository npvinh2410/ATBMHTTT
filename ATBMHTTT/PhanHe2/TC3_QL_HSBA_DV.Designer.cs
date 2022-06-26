
namespace ATBMHTTT.PhanHe2
{
    partial class TC3_QL_HSBA_DV
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.GridHSBA_DV = new System.Windows.Forms.DataGridView();
            this.HSBAlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridHSBA_DV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(240, 288);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 37);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(626, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 37);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // GridHSBA_DV
            // 
            this.GridHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHSBA_DV.Location = new System.Drawing.Point(51, 35);
            this.GridHSBA_DV.Name = "GridHSBA_DV";
            this.GridHSBA_DV.RowHeadersWidth = 51;
            this.GridHSBA_DV.RowTemplate.Height = 24;
            this.GridHSBA_DV.Size = new System.Drawing.Size(545, 300);
            this.GridHSBA_DV.TabIndex = 7;
            // 
            // HSBAlabel
            // 
            this.HSBAlabel.AutoSize = true;
            this.HSBAlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSBAlabel.Location = new System.Drawing.Point(618, 77);
            this.HSBAlabel.Name = "HSBAlabel";
            this.HSBAlabel.Size = new System.Drawing.Size(34, 20);
            this.HSBAlabel.TabIndex = 5;
            this.HSBAlabel.Text = "xyz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã HSBA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "HỒ SƠ BỆNH ÁN DỊCH VỤ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GridHSBA_DV);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(431, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 374);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.ngay);
            this.panel2.Controls.Add(this.ketqua);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.maDV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(27, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 374);
            this.panel2.TabIndex = 11;
            // 
            // ngay
            // 
            this.ngay.Location = new System.Drawing.Point(115, 154);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(213, 22);
            this.ngay.TabIndex = 32;
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(115, 204);
            this.ketqua.Multiline = true;
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(213, 61);
            this.ketqua.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Kết quả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ngày:";
            // 
            // maDV
            // 
            this.maDV.Location = new System.Drawing.Point(115, 96);
            this.maDV.Name = "maDV";
            this.maDV.Size = new System.Drawing.Size(213, 22);
            this.maDV.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mã DV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thêm dịch vụ";
            // 
            // TC3_QL_HSBA_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HSBAlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TC3_QL_HSBA_DV";
            this.Text = "TC3_QL_HSBA_DV";
            ((System.ComponentModel.ISupportInitialize)(this.GridHSBA_DV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView GridHSBA_DV;
        private System.Windows.Forms.Label HSBAlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ngay;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maDV;
        private System.Windows.Forms.Label label6;
    }
}