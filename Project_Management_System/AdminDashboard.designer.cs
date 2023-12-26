namespace Project_Management_System
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDBDataSet = new Project_Management_System.PMSDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_addfaculty = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_facultylist = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip_profile = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsTableAdapter = new Project_Management_System.PMSDBDataSetTableAdapters.ProjectsTableAdapter();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user1usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user1nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user2usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user2nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user3usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user3nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user4usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user4nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user5usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user5name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip_profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Location = new System.Drawing.Point(74, 291);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 6);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Location = new System.Drawing.Point(231, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 6);
            this.panel3.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectDataGridViewTextBoxColumn,
            this.projectdescriptionDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn,
            this.completationdateDataGridViewTextBoxColumn,
            this.user1usernameDataGridViewTextBoxColumn,
            this.user1nameDataGridViewTextBoxColumn,
            this.user2usernameDataGridViewTextBoxColumn,
            this.user2nameDataGridViewTextBoxColumn,
            this.user3usernameDataGridViewTextBoxColumn,
            this.user3nameDataGridViewTextBoxColumn,
            this.user4usernameDataGridViewTextBoxColumn,
            this.user4nameDataGridViewTextBoxColumn,
            this.user5usernameDataGridViewTextBoxColumn,
            this.user5name});
            this.dataGridView2.DataSource = this.projectsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(292, 147);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(908, 454);
            this.dataGridView2.TabIndex = 17;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.pMSDBDataSet;
            // 
            // pMSDBDataSet
            // 
            this.pMSDBDataSet.DataSetName = "PMSDBDataSet";
            this.pMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admin DashBoard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 6);
            this.panel2.TabIndex = 6;
            // 
            // btn_addfaculty
            // 
            this.btn_addfaculty.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_addfaculty.Location = new System.Drawing.Point(74, 315);
            this.btn_addfaculty.Name = "btn_addfaculty";
            this.btn_addfaculty.Size = new System.Drawing.Size(87, 32);
            this.btn_addfaculty.TabIndex = 8;
            this.btn_addfaculty.Text = "Add Faculty";
            this.btn_addfaculty.UseVisualStyleBackColor = false;
            this.btn_addfaculty.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(74, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Projects";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(74, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btn_facultylist);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_addfaculty);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Location = new System.Drawing.Point(8, -13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 692);
            this.panel1.TabIndex = 15;
            // 
            // btn_facultylist
            // 
            this.btn_facultylist.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_facultylist.Location = new System.Drawing.Point(74, 374);
            this.btn_facultylist.Name = "btn_facultylist";
            this.btn_facultylist.Size = new System.Drawing.Size(87, 32);
            this.btn_facultylist.TabIndex = 283;
            this.btn_facultylist.Text = "Faculty List";
            this.btn_facultylist.UseVisualStyleBackColor = false;
            this.btn_facultylist.Click += new System.EventHandler(this.btn_facultylist_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Location = new System.Drawing.Point(74, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 282;
            this.button3.Text = "MessageBox";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SkyBlue;
            this.BackButton.Location = new System.Drawing.Point(74, 628);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 29);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "LogOut";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(231, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Project List";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(1145, 40);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 24);
            this.button6.TabIndex = 279;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(972, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 27);
            this.textBox1.TabIndex = 280;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip_profile
            // 
            this.menuStrip_profile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_profile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.facultyListToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip_profile.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_profile.Name = "menuStrip_profile";
            this.menuStrip_profile.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_profile.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip_profile.TabIndex = 281;
            this.menuStrip_profile.Text = "menuStrip_profile";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.profileToolStripMenuItem.Text = "Account";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.projectToolStripMenuItem.Text = "Projects";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // facultyListToolStripMenuItem
            // 
            this.facultyListToolStripMenuItem.Name = "facultyListToolStripMenuItem";
            this.facultyListToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.facultyListToolStripMenuItem.Text = "Faculty ";
            this.facultyListToolStripMenuItem.Click += new System.EventHandler(this.facultyListToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "project";
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.Width = 200;
            // 
            // projectdescriptionDataGridViewTextBoxColumn
            // 
            this.projectdescriptionDataGridViewTextBoxColumn.DataPropertyName = "projectdescription";
            this.projectdescriptionDataGridViewTextBoxColumn.HeaderText = "projectdescription";
            this.projectdescriptionDataGridViewTextBoxColumn.Name = "projectdescriptionDataGridViewTextBoxColumn";
            this.projectdescriptionDataGridViewTextBoxColumn.Width = 450;
            // 
            // creationdateDataGridViewTextBoxColumn
            // 
            this.creationdateDataGridViewTextBoxColumn.DataPropertyName = "Creationdate";
            this.creationdateDataGridViewTextBoxColumn.HeaderText = "Creationdate";
            this.creationdateDataGridViewTextBoxColumn.Name = "creationdateDataGridViewTextBoxColumn";
            // 
            // completationdateDataGridViewTextBoxColumn
            // 
            this.completationdateDataGridViewTextBoxColumn.DataPropertyName = "Completationdate";
            this.completationdateDataGridViewTextBoxColumn.HeaderText = "Completationdate";
            this.completationdateDataGridViewTextBoxColumn.Name = "completationdateDataGridViewTextBoxColumn";
            // 
            // user1usernameDataGridViewTextBoxColumn
            // 
            this.user1usernameDataGridViewTextBoxColumn.DataPropertyName = "user1username";
            this.user1usernameDataGridViewTextBoxColumn.HeaderText = "user1username";
            this.user1usernameDataGridViewTextBoxColumn.Name = "user1usernameDataGridViewTextBoxColumn";
            // 
            // user1nameDataGridViewTextBoxColumn
            // 
            this.user1nameDataGridViewTextBoxColumn.DataPropertyName = "user1name";
            this.user1nameDataGridViewTextBoxColumn.HeaderText = "user1name";
            this.user1nameDataGridViewTextBoxColumn.Name = "user1nameDataGridViewTextBoxColumn";
            // 
            // user2usernameDataGridViewTextBoxColumn
            // 
            this.user2usernameDataGridViewTextBoxColumn.DataPropertyName = "user2username";
            this.user2usernameDataGridViewTextBoxColumn.HeaderText = "user2username";
            this.user2usernameDataGridViewTextBoxColumn.Name = "user2usernameDataGridViewTextBoxColumn";
            // 
            // user2nameDataGridViewTextBoxColumn
            // 
            this.user2nameDataGridViewTextBoxColumn.DataPropertyName = "user2name";
            this.user2nameDataGridViewTextBoxColumn.HeaderText = "user2name";
            this.user2nameDataGridViewTextBoxColumn.Name = "user2nameDataGridViewTextBoxColumn";
            // 
            // user3usernameDataGridViewTextBoxColumn
            // 
            this.user3usernameDataGridViewTextBoxColumn.DataPropertyName = "user3username";
            this.user3usernameDataGridViewTextBoxColumn.HeaderText = "user3username";
            this.user3usernameDataGridViewTextBoxColumn.Name = "user3usernameDataGridViewTextBoxColumn";
            // 
            // user3nameDataGridViewTextBoxColumn
            // 
            this.user3nameDataGridViewTextBoxColumn.DataPropertyName = "user3name";
            this.user3nameDataGridViewTextBoxColumn.HeaderText = "user3name";
            this.user3nameDataGridViewTextBoxColumn.Name = "user3nameDataGridViewTextBoxColumn";
            // 
            // user4usernameDataGridViewTextBoxColumn
            // 
            this.user4usernameDataGridViewTextBoxColumn.DataPropertyName = "user4username";
            this.user4usernameDataGridViewTextBoxColumn.HeaderText = "user4username";
            this.user4usernameDataGridViewTextBoxColumn.Name = "user4usernameDataGridViewTextBoxColumn";
            // 
            // user4nameDataGridViewTextBoxColumn
            // 
            this.user4nameDataGridViewTextBoxColumn.DataPropertyName = "user4name";
            this.user4nameDataGridViewTextBoxColumn.HeaderText = "user4name";
            this.user4nameDataGridViewTextBoxColumn.Name = "user4nameDataGridViewTextBoxColumn";
            // 
            // user5usernameDataGridViewTextBoxColumn
            // 
            this.user5usernameDataGridViewTextBoxColumn.DataPropertyName = "user5username";
            this.user5usernameDataGridViewTextBoxColumn.HeaderText = "user5username";
            this.user5usernameDataGridViewTextBoxColumn.Name = "user5usernameDataGridViewTextBoxColumn";
            // 
            // user5name
            // 
            this.user5name.DataPropertyName = "user5name";
            this.user5name.HeaderText = "user5name";
            this.user5name.Name = "user5name";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 675);
            this.Controls.Add(this.menuStrip_profile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1285, 716);
            this.MinimumSize = new System.Drawing.Size(1284, 714);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip_profile.ResumeLayout(false);
            this.menuStrip_profile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addfaculty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip_profile;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_facultylist;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private PMSDBDataSet pMSDBDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private PMSDBDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn user6nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user1usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user1nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user2usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user2nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user3usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user3nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user4usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user4nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user5usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user5name;
    }
}