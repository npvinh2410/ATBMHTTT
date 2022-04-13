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
            this.button4 = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.btnViewRole = new System.Windows.Forms.Button();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.privilegesGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.viewPrivilegesBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbuser = new System.Windows.Forms.ComboBox();
            this.cbbrole = new System.Windows.Forms.ComboBox();
            this.bt_capquyen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbrole_permission = new System.Windows.Forms.ComboBox();
            this.cbbrole_table = new System.Windows.Forms.ComboBox();
            this.cbbrole_collum = new System.Windows.Forms.ComboBox();
            this.cbbrole_role = new System.Windows.Forms.ComboBox();
            this.btrole_capquyen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbuser_table = new System.Windows.Forms.ComboBox();
            this.cbbuser_permission = new System.Windows.Forms.ComboBox();
            this.cbbuser_collum = new System.Windows.Forms.ComboBox();
            this.cbbuser_user = new System.Windows.Forms.ComboBox();
            this.btuser_capquyen = new System.Windows.Forms.Button();
            this.ckbgrant = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.btnView);
            this.tabPage1.Controls.Add(this.dataGridViewUser);
            this.tabPage1.Controls.Add(this.btnViewRole);
            this.tabPage1.Controls.Add(this.btnViewTable);
            this.tabPage1.Controls.Add(this.btnViewUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1051, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xem DS các đối tượng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 39);
            this.button4.TabIndex = 10;
            this.button4.Text = "Thêm bảng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(779, 49);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(204, 38);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "Xem DS View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(54, 185);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(929, 349);
            this.dataGridViewUser.TabIndex = 8;
            // 
            // btnViewRole
            // 
            this.btnViewRole.Location = new System.Drawing.Point(538, 49);
            this.btnViewRole.Name = "btnViewRole";
            this.btnViewRole.Size = new System.Drawing.Size(204, 38);
            this.btnViewRole.TabIndex = 7;
            this.btnViewRole.Text = "Xem DS Role";
            this.btnViewRole.UseVisualStyleBackColor = true;
            this.btnViewRole.Click += new System.EventHandler(this.btnViewRole_Click);
            // 
            // btnViewTable
            // 
            this.btnViewTable.Location = new System.Drawing.Point(294, 48);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(204, 39);
            this.btnViewTable.TabIndex = 6;
            this.btnViewTable.Text = "Xem DS Table";
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.Location = new System.Drawing.Point(54, 48);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(204, 39);
            this.btnViewUser.TabIndex = 5;
            this.btnViewUser.Text = "Xem DS User";
            this.btnViewUser.UseVisualStyleBackColor = true;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.privilegesGridView);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.edit);
            this.tabPage2.Controls.Add(this.delete);
            this.tabPage2.Controls.Add(this.userNameTextBox);
            this.tabPage2.Controls.Add(this.viewPrivilegesBtn);
            this.tabPage2.Controls.Add(this.userNameLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1051, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin quyền user/role (Của Trí)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(800, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 30);
            this.button3.TabIndex = 33;
            this.button3.Text = "Thêm role";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.themrole_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = "Thêm user";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.themuser_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 504);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "TABLE/VIEW";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(444, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "ASSIGNED ROLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "PRIVILEGE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "GRANTEE";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(640, 537);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(55, 30);
            this.textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(641, 446);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(225, 30);
            this.textBox3.TabIndex = 26;
            // 
            // privilegesGridView
            // 
            this.privilegesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.privilegesGridView.Location = new System.Drawing.Point(28, 131);
            this.privilegesGridView.Name = "privilegesGridView";
            this.privilegesGridView.RowHeadersWidth = 51;
            this.privilegesGridView.RowTemplate.Height = 24;
            this.privilegesGridView.Size = new System.Drawing.Size(870, 251);
            this.privilegesGridView.TabIndex = 20;
            this.privilegesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.privilegesGridView_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "REFERENCES",
            "ALTER",
            "INDEX",
            "ALL"});
            this.comboBox1.Location = new System.Drawing.Point(640, 498);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 33);
            this.comboBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(161, 501);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(225, 30);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(161, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(225, 30);
            this.textBox1.TabIndex = 23;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(928, 476);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(95, 30);
            this.edit.TabIndex = 22;
            this.edit.Text = "Cập nhật";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(928, 246);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(95, 30);
            this.delete.TabIndex = 21;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(177, 56);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(251, 30);
            this.userNameTextBox.TabIndex = 19;
            // 
            // viewPrivilegesBtn
            // 
            this.viewPrivilegesBtn.Location = new System.Drawing.Point(503, 56);
            this.viewPrivilegesBtn.Name = "viewPrivilegesBtn";
            this.viewPrivilegesBtn.Size = new System.Drawing.Size(95, 30);
            this.viewPrivilegesBtn.TabIndex = 18;
            this.viewPrivilegesBtn.Text = "Xem";
            this.viewPrivilegesBtn.UseVisualStyleBackColor = true;
            this.viewPrivilegesBtn.Click += new System.EventHandler(this.viewPrivilegesBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(23, 59);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(128, 25);
            this.userNameLabel.TabIndex = 17;
            this.userNameLabel.Text = "Tên user/role";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1051, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1051, 622);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cấp quyền";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbuser);
            this.groupBox3.Controls.Add(this.cbbrole);
            this.groupBox3.Controls.Add(this.bt_capquyen);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(56, 421);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(939, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cấp Role cho User";
            // 
            // cbbuser
            // 
            this.cbbuser.FormattingEnabled = true;
            this.cbbuser.Location = new System.Drawing.Point(483, 26);
            this.cbbuser.Name = "cbbuser";
            this.cbbuser.Size = new System.Drawing.Size(199, 24);
            this.cbbuser.TabIndex = 12;
            // 
            // cbbrole
            // 
            this.cbbrole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbrole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbrole.FormattingEnabled = true;
            this.cbbrole.Location = new System.Drawing.Point(129, 26);
            this.cbbrole.Name = "cbbrole";
            this.cbbrole.Size = new System.Drawing.Size(199, 24);
            this.cbbrole.TabIndex = 11;
            // 
            // bt_capquyen
            // 
            this.bt_capquyen.BackColor = System.Drawing.Color.Silver;
            this.bt_capquyen.Location = new System.Drawing.Point(787, 21);
            this.bt_capquyen.Margin = new System.Windows.Forms.Padding(4);
            this.bt_capquyen.Name = "bt_capquyen";
            this.bt_capquyen.Size = new System.Drawing.Size(101, 33);
            this.bt_capquyen.TabIndex = 9;
            this.bt_capquyen.Text = "Cấp quyền";
            this.bt_capquyen.UseVisualStyleBackColor = false;
            this.bt_capquyen.Click += new System.EventHandler(this.bt_capquyen_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên User";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên Role";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbrole_permission);
            this.groupBox2.Controls.Add(this.cbbrole_table);
            this.groupBox2.Controls.Add(this.cbbrole_collum);
            this.groupBox2.Controls.Add(this.cbbrole_role);
            this.groupBox2.Controls.Add(this.btrole_capquyen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(56, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(939, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cấp quyền cho Role";
            // 
            // cbbrole_permission
            // 
            this.cbbrole_permission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbrole_permission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbrole_permission.FormattingEnabled = true;
            this.cbbrole_permission.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.cbbrole_permission.Location = new System.Drawing.Point(485, 30);
            this.cbbrole_permission.Name = "cbbrole_permission";
            this.cbbrole_permission.Size = new System.Drawing.Size(199, 24);
            this.cbbrole_permission.TabIndex = 14;
            this.cbbrole_permission.SelectedIndexChanged += new System.EventHandler(this.cbbrole_permission_SelectedIndexChanged);
            // 
            // cbbrole_table
            // 
            this.cbbrole_table.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbrole_table.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbrole_table.FormattingEnabled = true;
            this.cbbrole_table.Location = new System.Drawing.Point(485, 78);
            this.cbbrole_table.Name = "cbbrole_table";
            this.cbbrole_table.Size = new System.Drawing.Size(199, 24);
            this.cbbrole_table.TabIndex = 13;
            this.cbbrole_table.SelectedIndexChanged += new System.EventHandler(this.cbbrole_table_SelectedIndexChanged);
            // 
            // cbbrole_collum
            // 
            this.cbbrole_collum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbrole_collum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbrole_collum.FormattingEnabled = true;
            this.cbbrole_collum.Location = new System.Drawing.Point(130, 75);
            this.cbbrole_collum.Name = "cbbrole_collum";
            this.cbbrole_collum.Size = new System.Drawing.Size(199, 24);
            this.cbbrole_collum.TabIndex = 12;
            // 
            // cbbrole_role
            // 
            this.cbbrole_role.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbrole_role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbrole_role.FormattingEnabled = true;
            this.cbbrole_role.Location = new System.Drawing.Point(131, 30);
            this.cbbrole_role.Name = "cbbrole_role";
            this.cbbrole_role.Size = new System.Drawing.Size(199, 24);
            this.cbbrole_role.TabIndex = 11;
            // 
            // btrole_capquyen
            // 
            this.btrole_capquyen.BackColor = System.Drawing.Color.Silver;
            this.btrole_capquyen.Location = new System.Drawing.Point(788, 71);
            this.btrole_capquyen.Margin = new System.Windows.Forms.Padding(4);
            this.btrole_capquyen.Name = "btrole_capquyen";
            this.btrole_capquyen.Size = new System.Drawing.Size(101, 33);
            this.btrole_capquyen.TabIndex = 9;
            this.btrole_capquyen.Text = "Cấp quyền";
            this.btrole_capquyen.UseVisualStyleBackColor = false;
            this.btrole_capquyen.Click += new System.EventHandler(this.btrole_capquyen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên bảng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên cột";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Role";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbuser_table);
            this.groupBox1.Controls.Add(this.cbbuser_permission);
            this.groupBox1.Controls.Add(this.cbbuser_collum);
            this.groupBox1.Controls.Add(this.cbbuser_user);
            this.groupBox1.Controls.Add(this.btuser_capquyen);
            this.groupBox1.Controls.Add(this.ckbgrant);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(939, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấp quyền cho User";
            // 
            // cbbuser_table
            // 
            this.cbbuser_table.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbuser_table.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbuser_table.FormattingEnabled = true;
            this.cbbuser_table.Location = new System.Drawing.Point(485, 78);
            this.cbbuser_table.Name = "cbbuser_table";
            this.cbbuser_table.Size = new System.Drawing.Size(199, 24);
            this.cbbuser_table.TabIndex = 13;
            this.cbbuser_table.SelectedIndexChanged += new System.EventHandler(this.cbbuser_table_SelectedIndexChanged);
            // 
            // cbbuser_permission
            // 
            this.cbbuser_permission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbuser_permission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbuser_permission.FormattingEnabled = true;
            this.cbbuser_permission.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.cbbuser_permission.Location = new System.Drawing.Point(485, 27);
            this.cbbuser_permission.Name = "cbbuser_permission";
            this.cbbuser_permission.Size = new System.Drawing.Size(199, 24);
            this.cbbuser_permission.TabIndex = 12;
            this.cbbuser_permission.SelectedIndexChanged += new System.EventHandler(this.cbbuser_permission_SelectedIndexChanged);
            // 
            // cbbuser_collum
            // 
            this.cbbuser_collum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbuser_collum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbuser_collum.FormattingEnabled = true;
            this.cbbuser_collum.Location = new System.Drawing.Point(131, 79);
            this.cbbuser_collum.Name = "cbbuser_collum";
            this.cbbuser_collum.Size = new System.Drawing.Size(199, 24);
            this.cbbuser_collum.TabIndex = 11;
            this.cbbuser_collum.SelectedIndexChanged += new System.EventHandler(this.cbbuser_collum_SelectedIndexChanged);
            // 
            // cbbuser_user
            // 
            this.cbbuser_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbuser_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbuser_user.FormattingEnabled = true;
            this.cbbuser_user.Location = new System.Drawing.Point(130, 27);
            this.cbbuser_user.Name = "cbbuser_user";
            this.cbbuser_user.Size = new System.Drawing.Size(199, 24);
            this.cbbuser_user.TabIndex = 10;
            // 
            // btuser_capquyen
            // 
            this.btuser_capquyen.BackColor = System.Drawing.Color.Silver;
            this.btuser_capquyen.Location = new System.Drawing.Point(788, 71);
            this.btuser_capquyen.Margin = new System.Windows.Forms.Padding(4);
            this.btuser_capquyen.Name = "btuser_capquyen";
            this.btuser_capquyen.Size = new System.Drawing.Size(101, 33);
            this.btuser_capquyen.TabIndex = 9;
            this.btuser_capquyen.Text = "Cấp quyền";
            this.btuser_capquyen.UseVisualStyleBackColor = false;
            this.btuser_capquyen.Click += new System.EventHandler(this.btuser_capquyen_Click);
            // 
            // ckbgrant
            // 
            this.ckbgrant.AutoSize = true;
            this.ckbgrant.Location = new System.Drawing.Point(781, 33);
            this.ckbgrant.Margin = new System.Windows.Forms.Padding(4);
            this.ckbgrant.Name = "ckbgrant";
            this.ckbgrant.Size = new System.Drawing.Size(134, 21);
            this.ckbgrant.TabIndex = 8;
            this.ckbgrant.Text = "with grant option";
            this.ckbgrant.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên bảng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên cột";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1059, 649);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView privilegesGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button viewPrivilegesBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button btnViewRole;
        private System.Windows.Forms.Button btnViewTable;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbuser;
        private System.Windows.Forms.ComboBox cbbrole;
        private System.Windows.Forms.Button bt_capquyen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbrole_permission;
        private System.Windows.Forms.ComboBox cbbrole_table;
        private System.Windows.Forms.ComboBox cbbrole_collum;
        private System.Windows.Forms.ComboBox cbbrole_role;
        private System.Windows.Forms.Button btrole_capquyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbuser_table;
        private System.Windows.Forms.ComboBox cbbuser_permission;
        private System.Windows.Forms.ComboBox cbbuser_collum;
        private System.Windows.Forms.ComboBox cbbuser_user;
        private System.Windows.Forms.Button btuser_capquyen;
        private System.Windows.Forms.CheckBox ckbgrant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

