namespace Project_Management_System
{
    partial class Add_Project
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_projectname = new System.Windows.Forms.TextBox();
            this.richTextBox_projectdescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.listView_search = new System.Windows.Forms.ListView();
            this.listView_assaignedpeople = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.button_addproject = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_projectcreator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(734, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description";
            // 
            // textBox_projectname
            // 
            this.textBox_projectname.Location = new System.Drawing.Point(248, 58);
            this.textBox_projectname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_projectname.Name = "textBox_projectname";
            this.textBox_projectname.Size = new System.Drawing.Size(421, 26);
            this.textBox_projectname.TabIndex = 3;
            // 
            // richTextBox_projectdescription
            // 
            this.richTextBox_projectdescription.Location = new System.Drawing.Point(956, 68);
            this.richTextBox_projectdescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_projectdescription.Name = "richTextBox_projectdescription";
            this.richTextBox_projectdescription.Size = new System.Drawing.Size(421, 133);
            this.richTextBox_projectdescription.TabIndex = 4;
            this.richTextBox_projectdescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assign People";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(484, 348);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(190, 26);
            this.textBox_search.TabIndex = 6;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // listView_search
            // 
            this.listView_search.HideSelection = false;
            this.listView_search.Location = new System.Drawing.Point(342, 409);
            this.listView_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(439, 418);
            this.listView_search.TabIndex = 7;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            this.listView_search.SelectedIndexChanged += new System.EventHandler(this.listView_search_SelectedIndexChanged);
            // 
            // listView_assaignedpeople
            // 
            this.listView_assaignedpeople.HideSelection = false;
            this.listView_assaignedpeople.Location = new System.Drawing.Point(1064, 409);
            this.listView_assaignedpeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView_assaignedpeople.Name = "listView_assaignedpeople";
            this.listView_assaignedpeople.Size = new System.Drawing.Size(198, 418);
            this.listView_assaignedpeople.TabIndex = 8;
            this.listView_assaignedpeople.UseCompatibleStateImageBehavior = false;
            this.listView_assaignedpeople.SelectedIndexChanged += new System.EventHandler(this.listView_assaignedpeople_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1089, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assigned People";
            // 
            // button_addproject
            // 
            this.button_addproject.Location = new System.Drawing.Point(1144, 900);
            this.button_addproject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_addproject.Name = "button_addproject";
            this.button_addproject.Size = new System.Drawing.Size(142, 35);
            this.button_addproject.TabIndex = 10;
            this.button_addproject.Text = "Add Project";
            this.button_addproject.UseVisualStyleBackColor = true;
            this.button_addproject.Click += new System.EventHandler(this.button_addproject_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(700, 348);
            this.button_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(112, 35);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(381, 172);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(283, 26);
            this.dateTimePicker2.TabIndex = 244;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 29);
            this.label7.TabIndex = 243;
            this.label7.Text = "Creation Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(381, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 26);
            this.dateTimePicker1.TabIndex = 242;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 29);
            this.label6.TabIndex = 241;
            this.label6.Text = "Completation date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(87, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 18);
            this.panel1.TabIndex = 250;
            // 
            // textBox_projectcreator
            // 
            this.textBox_projectcreator.Location = new System.Drawing.Point(248, 117);
            this.textBox_projectcreator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_projectcreator.Name = "textBox_projectcreator";
            this.textBox_projectcreator.Size = new System.Drawing.Size(421, 26);
            this.textBox_projectcreator.TabIndex = 251;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 252;
            this.label5.Text = "Project Creator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 900);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 253;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 949);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_projectcreator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_addproject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_assaignedpeople);
            this.Controls.Add(this.listView_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_projectdescription);
            this.Controls.Add(this.textBox_projectname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add_Project";
            this.Text = "Add Project";
            this.Load += new System.EventHandler(this.Add_Project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_projectname;
        private System.Windows.Forms.RichTextBox richTextBox_projectdescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.ListView listView_assaignedpeople;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_addproject;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_projectcreator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}