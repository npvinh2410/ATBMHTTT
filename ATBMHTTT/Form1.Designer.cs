using Oracle.ManagedDataAccess.Client;
namespace ATBMHTTT
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.privilegesGridView = new System.Windows.Forms.DataGridView();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.viewPrivilegesBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbuser_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tbuser_quyen = new System.Windows.Forms.TextBox();
            this.tbuser_cot = new System.Windows.Forms.TextBox();
            this.tbuser_bang = new System.Windows.Forms.TextBox();
            this.ckbgrant = new System.Windows.Forms.CheckBox();
            this.btuser_capquyen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btrole_capquyen = new System.Windows.Forms.Button();
            this.tbrole_bang = new System.Windows.Forms.TextBox();
            this.tbrole_cot = new System.Windows.Forms.TextBox();
            this.tbrole_quyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbrole_user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_capquyen = new System.Windows.Forms.Button();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbrole = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(786, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.privilegesGridView);
            this.tabPage2.Controls.Add(this.userNameTextBox);
            this.tabPage2.Controls.Add(this.roleNameTextBox);
            this.tabPage2.Controls.Add(this.viewPrivilegesBtn);
            this.tabPage2.Controls.Add(this.userNameLabel);
            this.tabPage2.Controls.Add(this.roleNameLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(786, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin quyền user/role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // privilegesGridView
            // 
            this.privilegesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.privilegesGridView.Location = new System.Drawing.Point(27, 89);
            this.privilegesGridView.Margin = new System.Windows.Forms.Padding(2);
            this.privilegesGridView.Name = "privilegesGridView";
            this.privilegesGridView.RowHeadersWidth = 51;
            this.privilegesGridView.RowTemplate.Height = 24;
            this.privilegesGridView.Size = new System.Drawing.Size(690, 374);
            this.privilegesGridView.TabIndex = 5;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(408, 36);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(170, 26);
            this.userNameTextBox.TabIndex = 4;
            // 
            // roleNameTextBox
            // 
            this.roleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameTextBox.Location = new System.Drawing.Point(91, 34);
            this.roleNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.roleNameTextBox.Name = "roleNameTextBox";
            this.roleNameTextBox.Size = new System.Drawing.Size(170, 26);
            this.roleNameTextBox.TabIndex = 3;
            // 
            // viewPrivilegesBtn
            // 
            this.viewPrivilegesBtn.Location = new System.Drawing.Point(646, 37);
            this.viewPrivilegesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewPrivilegesBtn.Name = "viewPrivilegesBtn";
            this.viewPrivilegesBtn.Size = new System.Drawing.Size(71, 24);
            this.viewPrivilegesBtn.TabIndex = 2;
            this.viewPrivilegesBtn.Text = "Xem";
            this.viewPrivilegesBtn.UseVisualStyleBackColor = true;
            this.viewPrivilegesBtn.Click += new System.EventHandler(this.viewPrivilegesBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(336, 38);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 20);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Tên user";
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameLabel.Location = new System.Drawing.Point(23, 38);
            this.roleNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(66, 20);
            this.roleNameLabel.TabIndex = 0;
            this.roleNameLabel.Text = "Tên role";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(786, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(786, 503);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cấp quyền";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btuser_capquyen);
            this.groupBox1.Controls.Add(this.ckbgrant);
            this.groupBox1.Controls.Add(this.tbuser_bang);
            this.groupBox1.Controls.Add(this.tbuser_cot);
            this.groupBox1.Controls.Add(this.tbuser_quyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbuser_user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(704, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấp quyền cho User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên bảng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên quyền";
            // 
            // tbuser_user
            // 
            this.tbuser_user.Location = new System.Drawing.Point(97, 21);
            this.tbuser_user.Name = "tbuser_user";
            this.tbuser_user.Size = new System.Drawing.Size(152, 20);
            this.tbuser_user.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên cột";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên User";
            // 
            // tbuser_quyen
            // 
            this.tbuser_quyen.Location = new System.Drawing.Point(362, 24);
            this.tbuser_quyen.Name = "tbuser_quyen";
            this.tbuser_quyen.Size = new System.Drawing.Size(152, 20);
            this.tbuser_quyen.TabIndex = 5;
            // 
            // tbuser_cot
            // 
            this.tbuser_cot.Location = new System.Drawing.Point(97, 61);
            this.tbuser_cot.Name = "tbuser_cot";
            this.tbuser_cot.Size = new System.Drawing.Size(152, 20);
            this.tbuser_cot.TabIndex = 6;
            // 
            // tbuser_bang
            // 
            this.tbuser_bang.Location = new System.Drawing.Point(362, 61);
            this.tbuser_bang.Name = "tbuser_bang";
            this.tbuser_bang.Size = new System.Drawing.Size(152, 20);
            this.tbuser_bang.TabIndex = 7;
            // 
            // ckbgrant
            // 
            this.ckbgrant.AutoSize = true;
            this.ckbgrant.Location = new System.Drawing.Point(586, 27);
            this.ckbgrant.Name = "ckbgrant";
            this.ckbgrant.Size = new System.Drawing.Size(104, 17);
            this.ckbgrant.TabIndex = 8;
            this.ckbgrant.Text = "with grant option";
            this.ckbgrant.UseVisualStyleBackColor = true;
            this.ckbgrant.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btuser_capquyen
            // 
            this.btuser_capquyen.BackColor = System.Drawing.Color.Silver;
            this.btuser_capquyen.Location = new System.Drawing.Point(591, 58);
            this.btuser_capquyen.Name = "btuser_capquyen";
            this.btuser_capquyen.Size = new System.Drawing.Size(76, 27);
            this.btuser_capquyen.TabIndex = 9;
            this.btuser_capquyen.Text = "Cấp quyền";
            this.btuser_capquyen.UseVisualStyleBackColor = false;
            this.btuser_capquyen.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btrole_capquyen);
            this.groupBox2.Controls.Add(this.tbrole_bang);
            this.groupBox2.Controls.Add(this.tbrole_cot);
            this.groupBox2.Controls.Add(this.tbrole_quyen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbrole_user);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(37, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(704, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cấp quyền cho Role";
            // 
            // btrole_capquyen
            // 
            this.btrole_capquyen.BackColor = System.Drawing.Color.Silver;
            this.btrole_capquyen.Location = new System.Drawing.Point(591, 58);
            this.btrole_capquyen.Name = "btrole_capquyen";
            this.btrole_capquyen.Size = new System.Drawing.Size(76, 27);
            this.btrole_capquyen.TabIndex = 9;
            this.btrole_capquyen.Text = "Cấp quyền";
            this.btrole_capquyen.UseVisualStyleBackColor = false;
            this.btrole_capquyen.Click += new System.EventHandler(this.btrole_capquyen_Click);
            // 
            // tbrole_bang
            // 
            this.tbrole_bang.Location = new System.Drawing.Point(362, 61);
            this.tbrole_bang.Name = "tbrole_bang";
            this.tbrole_bang.Size = new System.Drawing.Size(152, 20);
            this.tbrole_bang.TabIndex = 7;
            // 
            // tbrole_cot
            // 
            this.tbrole_cot.Location = new System.Drawing.Point(97, 61);
            this.tbrole_cot.Name = "tbrole_cot";
            this.tbrole_cot.Size = new System.Drawing.Size(152, 20);
            this.tbrole_cot.TabIndex = 6;
            // 
            // tbrole_quyen
            // 
            this.tbrole_quyen.Location = new System.Drawing.Point(362, 24);
            this.tbrole_quyen.Name = "tbrole_quyen";
            this.tbrole_quyen.Size = new System.Drawing.Size(152, 20);
            this.tbrole_quyen.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên bảng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên quyền";
            // 
            // tbrole_user
            // 
            this.tbrole_user.Location = new System.Drawing.Point(97, 21);
            this.tbrole_user.Name = "tbrole_user";
            this.tbrole_user.Size = new System.Drawing.Size(152, 20);
            this.tbrole_user.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên cột";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên User";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_capquyen);
            this.groupBox3.Controls.Add(this.tbuser);
            this.groupBox3.Controls.Add(this.tbrole);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(38, 345);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(704, 61);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cấp Role cho User";
            // 
            // bt_capquyen
            // 
            this.bt_capquyen.BackColor = System.Drawing.Color.Silver;
            this.bt_capquyen.Location = new System.Drawing.Point(590, 17);
            this.bt_capquyen.Name = "bt_capquyen";
            this.bt_capquyen.Size = new System.Drawing.Size(76, 27);
            this.bt_capquyen.TabIndex = 9;
            this.bt_capquyen.Text = "Cấp quyền";
            this.bt_capquyen.UseVisualStyleBackColor = false;
            this.bt_capquyen.Click += new System.EventHandler(this.bt_capquyen_Click);
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(361, 21);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(152, 20);
            this.tbuser.TabIndex = 6;
            // 
            // tbrole
            // 
            this.tbrole.Location = new System.Drawing.Point(97, 21);
            this.tbrole.Name = "tbrole";
            this.tbrole.Size = new System.Drawing.Size(152, 20);
            this.tbrole.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên User";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên Role";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(796, 531);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button viewPrivilegesBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label roleNameLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.DataGridView privilegesGridView;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbuser_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_capquyen;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbrole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btrole_capquyen;
        private System.Windows.Forms.TextBox tbrole_bang;
        private System.Windows.Forms.TextBox tbrole_cot;
        private System.Windows.Forms.TextBox tbrole_quyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbrole_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btuser_capquyen;
        private System.Windows.Forms.CheckBox ckbgrant;
        private System.Windows.Forms.TextBox tbuser_bang;
        private System.Windows.Forms.TextBox tbuser_cot;
        private System.Windows.Forms.TextBox tbuser_quyen;
    }
}

