
namespace ATBMHTTT
{
    partial class ThemUser
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
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.Huy = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(253, 107);
            this.tbpass.Multiline = true;
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(247, 33);
            this.tbpass.TabIndex = 1;
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(253, 45);
            this.tbuser.Multiline = true;
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(247, 33);
            this.tbuser.TabIndex = 0;
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(76, 110);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(66, 17);
            this.lbpass.TabIndex = 8;
            this.lbpass.Text = "Mật khẩu";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(76, 48);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(105, 17);
            this.lbuser.TabIndex = 6;
            this.lbuser.Text = "Tên đăng nhập";
            // 
            // Huy
            // 
            this.Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Huy.Location = new System.Drawing.Point(406, 176);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(94, 35);
            this.Huy.TabIndex = 3;
            this.Huy.Text = "Hủy";
            this.Huy.UseVisualStyleBackColor = true;
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(253, 176);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(104, 36);
            this.Them.TabIndex = 2;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // ThemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 256);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.Them);
            this.Name = "ThemUser";
            this.Text = "ThemUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Button Huy;
        private System.Windows.Forms.Button Them;
    }
}