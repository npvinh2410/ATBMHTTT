
namespace ATBMHTTT.PhanHe2
{
    partial class TC5_NC_Xem_HSBADV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridHSBA_DV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHSBA_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GridHSBA_DV);
            this.panel1.Location = new System.Drawing.Point(70, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 348);
            this.panel1.TabIndex = 13;
            // 
            // GridHSBA_DV
            // 
            this.GridHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHSBA_DV.Location = new System.Drawing.Point(41, 35);
            this.GridHSBA_DV.Name = "GridHSBA_DV";
            this.GridHSBA_DV.RowHeadersWidth = 51;
            this.GridHSBA_DV.RowTemplate.Height = 24;
            this.GridHSBA_DV.Size = new System.Drawing.Size(558, 250);
            this.GridHSBA_DV.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "HỒ SƠ BỆNH ÁN DỊCH VỤ";
            // 
            // TC5_NC_Xem_HSBADV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TC5_NC_Xem_HSBADV";
            this.Text = "TC5_NC_Xem_HSBADV";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHSBA_DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridHSBA_DV;
        private System.Windows.Forms.Label label1;
    }
}