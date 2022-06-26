
namespace ATBMHTTT.PhanHe2
{
    partial class TC5_NV_NC_Xem_HSBA
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
            this.hsba = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_hsba = new System.Windows.Forms.DataGridView();
            this.XemHSBA = new System.Windows.Forms.Button();
            this.XemTT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsba)).BeginInit();
            this.SuspendLayout();
            // 
            // hsba
            // 
            this.hsba.AutoSize = true;
            this.hsba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsba.Location = new System.Drawing.Point(183, 30);
            this.hsba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hsba.Name = "hsba";
            this.hsba.Size = new System.Drawing.Size(271, 29);
            this.hsba.TabIndex = 3;
            this.hsba.Text = "Nhân Viên Nghiên Cứu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_hsba);
            this.panel1.Location = new System.Drawing.Point(33, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 324);
            this.panel1.TabIndex = 2;
            // 
            // dgv_hsba
            // 
            this.dgv_hsba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsba.Location = new System.Drawing.Point(4, 4);
            this.dgv_hsba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_hsba.Name = "dgv_hsba";
            this.dgv_hsba.RowHeadersWidth = 51;
            this.dgv_hsba.Size = new System.Drawing.Size(596, 316);
            this.dgv_hsba.TabIndex = 0;
            // 
            // XemHSBA
            // 
            this.XemHSBA.Location = new System.Drawing.Point(37, 137);
            this.XemHSBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XemHSBA.Name = "XemHSBA";
            this.XemHSBA.Size = new System.Drawing.Size(133, 53);
            this.XemHSBA.TabIndex = 4;
            this.XemHSBA.Text = "Xem HSBA";
            this.XemHSBA.UseVisualStyleBackColor = true;
            this.XemHSBA.Click += new System.EventHandler(this.XemHSBA_Click);
            // 
            // XemTT
            // 
            this.XemTT.AutoSize = true;
            this.XemTT.Location = new System.Drawing.Point(515, 15);
            this.XemTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XemTT.Name = "XemTT";
            this.XemTT.Size = new System.Drawing.Size(139, 36);
            this.XemTT.TabIndex = 5;
            this.XemTT.Text = "Thông tin cá nhân";
            this.XemTT.UseVisualStyleBackColor = true;
            this.XemTT.Click += new System.EventHandler(this.XemTT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Chi Tiết DV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TC5_NV_NC_Xem_HSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 566);
            this.Controls.Add(this.XemTT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.XemHSBA);
            this.Controls.Add(this.hsba);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TC5_NV_NC_Xem_HSBA";
            this.Text = "TC5_NC_Xem_HSBA";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hsba;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_hsba;
        private System.Windows.Forms.Button XemHSBA;
        private System.Windows.Forms.Button XemTT;
        private System.Windows.Forms.Button button1;
    }
}