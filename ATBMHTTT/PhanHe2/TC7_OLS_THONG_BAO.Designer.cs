
namespace ATBMHTTT.PhanHe2
{
    partial class TC7_OLS_THONG_BAO
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
            this.GridThongBao = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xemBtn = new System.Windows.Forms.Button();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIADIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridThongBao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG BÁO CUỘC HỌP KHẨN CSYT";
            // 
            // GridThongBao
            // 
            this.GridThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOIDUNG,
            this.NGAYGIO,
            this.DIADIEM});
            this.GridThongBao.Location = new System.Drawing.Point(0, 0);
            this.GridThongBao.Name = "GridThongBao";
            this.GridThongBao.RowHeadersWidth = 51;
            this.GridThongBao.RowTemplate.Height = 24;
            this.GridThongBao.Size = new System.Drawing.Size(716, 422);
            this.GridThongBao.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xemBtn);
            this.panel1.Controls.Add(this.GridThongBao);
            this.panel1.Location = new System.Drawing.Point(38, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 428);
            this.panel1.TabIndex = 2;
            // 
            // xemBtn
            // 
            this.xemBtn.Location = new System.Drawing.Point(753, 30);
            this.xemBtn.Name = "xemBtn";
            this.xemBtn.Size = new System.Drawing.Size(88, 59);
            this.xemBtn.TabIndex = 2;
            this.xemBtn.Text = "Xem thông báo";
            this.xemBtn.UseVisualStyleBackColor = true;
            this.xemBtn.Click += new System.EventHandler(this.xemBtn_Click);
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.HeaderText = "NOIDUNG";
            this.NOIDUNG.MinimumWidth = 6;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 300;
            // 
            // NGAYGIO
            // 
            this.NGAYGIO.HeaderText = "NGAYGIO";
            this.NGAYGIO.MinimumWidth = 6;
            this.NGAYGIO.Name = "NGAYGIO";
            this.NGAYGIO.Width = 125;
            // 
            // DIADIEM
            // 
            this.DIADIEM.HeaderText = "DIADIEM";
            this.DIADIEM.MinimumWidth = 6;
            this.DIADIEM.Name = "DIADIEM";
            this.DIADIEM.Width = 70;
            // 
            // TC7_OLS_THONG_BAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TC7_OLS_THONG_BAO";
            this.Text = "TC7_OLS_THONG_BAO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TC7_OLS_THONG_BAO_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GridThongBao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridThongBao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button xemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIADIEM;
    }
}