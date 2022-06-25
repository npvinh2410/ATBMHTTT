
namespace ATBMHTTT.PhanHe2
{
    partial class TC1_HOME
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
            this.btnQLcsyt = new System.Windows.Forms.Button();
            this.btnQNbn = new System.Windows.Forms.Button();
            this.btnQLbn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLcsyt
            // 
            this.btnQLcsyt.Location = new System.Drawing.Point(78, 193);
            this.btnQLcsyt.Name = "btnQLcsyt";
            this.btnQLcsyt.Size = new System.Drawing.Size(169, 70);
            this.btnQLcsyt.TabIndex = 0;
            this.btnQLcsyt.Text = "Quản lý CSYT";
            this.btnQLcsyt.UseVisualStyleBackColor = true;
            this.btnQLcsyt.Click += new System.EventHandler(this.btnQLcsyt_Click);
            // 
            // btnQNbn
            // 
            this.btnQNbn.Location = new System.Drawing.Point(307, 193);
            this.btnQNbn.Name = "btnQNbn";
            this.btnQNbn.Size = new System.Drawing.Size(169, 70);
            this.btnQNbn.TabIndex = 1;
            this.btnQNbn.Text = "Quản lý Nhân viên";
            this.btnQNbn.UseVisualStyleBackColor = true;
            this.btnQNbn.Click += new System.EventHandler(this.btnQNbn_Click);
            // 
            // btnQLbn
            // 
            this.btnQLbn.Location = new System.Drawing.Point(533, 193);
            this.btnQLbn.Name = "btnQLbn";
            this.btnQLbn.Size = new System.Drawing.Size(169, 70);
            this.btnQLbn.TabIndex = 1;
            this.btnQLbn.Text = "Quản lý Bệnh nhân";
            this.btnQLbn.UseVisualStyleBackColor = true;
            this.btnQLbn.Click += new System.EventHandler(this.btnQLbn_Click);
            // 
            // TC1_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQLbn);
            this.Controls.Add(this.btnQNbn);
            this.Controls.Add(this.btnQLcsyt);
            this.Name = "TC1_HOME";
            this.Text = "TC1_HOME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLcsyt;
        private System.Windows.Forms.Button btnQNbn;
        private System.Windows.Forms.Button btnQLbn;
    }
}