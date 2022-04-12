
namespace ATBMHTTT
{
    partial class ThemRole
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
            this.tbrole = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.Label();
            this.Huy = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbrole
            // 
            this.tbrole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrole.Location = new System.Drawing.Point(146, 34);
            this.tbrole.Multiline = true;
            this.tbrole.Name = "tbrole";
            this.tbrole.Size = new System.Drawing.Size(233, 41);
            this.tbrole.TabIndex = 0;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(33, 48);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(55, 25);
            this.Role.TabIndex = 5;
            this.Role.Text = "Role";
            // 
            // Huy
            // 
            this.Huy.Location = new System.Drawing.Point(298, 149);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(82, 32);
            this.Huy.TabIndex = 2;
            this.Huy.Text = "Hủy";
            this.Huy.UseVisualStyleBackColor = true;
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(147, 149);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 32);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // ThemRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 217);
            this.Controls.Add(this.tbrole);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.Them);
            this.Name = "ThemRole";
            this.Text = "ThemRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbrole;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Button Huy;
        private System.Windows.Forms.Button Them;
    }
}