namespace MyAddressBook_r81518
{
    partial class ContactDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.phone4_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.phone3_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.phone2_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.phone1_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fullName_txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteContact_button = new System.Windows.Forms.Button();
            this.addContact_button = new System.Windows.Forms.Button();
            this.updateContact_button = new System.Windows.Forms.Button();
            this.notes_txtbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.website_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.companyName_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.importContacts_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(178, 316);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseWaitCursor = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // column1
            // 
            this.column1.Text = "Full Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.phone4_txtbox);
            this.groupBox2.Controls.Add(this.phone3_txtbox);
            this.groupBox2.Controls.Add(this.phone2_txtbox);
            this.groupBox2.Controls.Add(this.phone1_txtbox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.fullName_txtbox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.deleteContact_button);
            this.groupBox2.Controls.Add(this.addContact_button);
            this.groupBox2.Controls.Add(this.updateContact_button);
            this.groupBox2.Controls.Add(this.notes_txtbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.website_txtbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.email_txtbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.companyName_txtbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lastName_txtbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.firstName_txtbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(202, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 443);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "information";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(276, 305);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "ext";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(299, 301);
            this.textBox4.MaxLength = 4;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 20);
            this.textBox4.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(276, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "ext";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 264);
            this.textBox3.MaxLength = 4;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(276, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "ext";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 225);
            this.textBox2.MaxLength = 4;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(276, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "ext";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 185);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 37;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Mobile",
            "Fax"});
            this.comboBox4.Location = new System.Drawing.Point(176, 301);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(93, 21);
            this.comboBox4.TabIndex = 36;
            this.comboBox4.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Mobile",
            "Fax"});
            this.comboBox3.Location = new System.Drawing.Point(176, 262);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(93, 21);
            this.comboBox3.TabIndex = 35;
            this.comboBox3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Mobile",
            "Fax"});
            this.comboBox2.Location = new System.Drawing.Point(176, 224);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 21);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Mobile",
            "Fax"});
            this.comboBox1.Location = new System.Drawing.Point(176, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 9);
            this.label14.TabIndex = 32;
            this.label14.Text = "add phone";
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 9);
            this.label13.TabIndex = 31;
            this.label13.Text = "add phone";
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 9);
            this.label12.TabIndex = 30;
            this.label12.Text = "add phone";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // phone4_txtbox
            // 
            this.phone4_txtbox.Location = new System.Drawing.Point(59, 302);
            this.phone4_txtbox.Mask = "(999) 000-0000";
            this.phone4_txtbox.Name = "phone4_txtbox";
            this.phone4_txtbox.Size = new System.Drawing.Size(103, 20);
            this.phone4_txtbox.TabIndex = 29;
            this.phone4_txtbox.Visible = false;
            // 
            // phone3_txtbox
            // 
            this.phone3_txtbox.Location = new System.Drawing.Point(59, 263);
            this.phone3_txtbox.Mask = "(999) 000-0000";
            this.phone3_txtbox.Name = "phone3_txtbox";
            this.phone3_txtbox.Size = new System.Drawing.Size(103, 20);
            this.phone3_txtbox.TabIndex = 28;
            this.phone3_txtbox.Visible = false;
            // 
            // phone2_txtbox
            // 
            this.phone2_txtbox.Location = new System.Drawing.Point(59, 224);
            this.phone2_txtbox.Mask = "(999) 000-0000";
            this.phone2_txtbox.Name = "phone2_txtbox";
            this.phone2_txtbox.Size = new System.Drawing.Size(103, 20);
            this.phone2_txtbox.TabIndex = 27;
            this.phone2_txtbox.Visible = false;
            // 
            // phone1_txtbox
            // 
            this.phone1_txtbox.Location = new System.Drawing.Point(59, 185);
            this.phone1_txtbox.Mask = "(999) 000-0000";
            this.phone1_txtbox.Name = "phone1_txtbox";
            this.phone1_txtbox.Size = new System.Drawing.Size(103, 20);
            this.phone1_txtbox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Phone 4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Phone 3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Visible = false;
            // 
            // fullName_txtbox
            // 
            this.fullName_txtbox.Location = new System.Drawing.Point(23, 73);
            this.fullName_txtbox.Name = "fullName_txtbox";
            this.fullName_txtbox.ReadOnly = true;
            this.fullName_txtbox.Size = new System.Drawing.Size(322, 20);
            this.fullName_txtbox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Full Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteContact_button
            // 
            this.deleteContact_button.Location = new System.Drawing.Point(366, 135);
            this.deleteContact_button.Name = "deleteContact_button";
            this.deleteContact_button.Size = new System.Drawing.Size(102, 23);
            this.deleteContact_button.TabIndex = 18;
            this.deleteContact_button.Text = "Delete Contact";
            this.deleteContact_button.UseVisualStyleBackColor = true;
            this.deleteContact_button.Click += new System.EventHandler(this.DeleteContact_button_Click);
            // 
            // addContact_button
            // 
            this.addContact_button.Location = new System.Drawing.Point(366, 47);
            this.addContact_button.Name = "addContact_button";
            this.addContact_button.Size = new System.Drawing.Size(102, 23);
            this.addContact_button.TabIndex = 17;
            this.addContact_button.Text = "Add Contact";
            this.addContact_button.UseVisualStyleBackColor = true;
            this.addContact_button.Click += new System.EventHandler(this.AddContact_button_Click);
            // 
            // updateContact_button
            // 
            this.updateContact_button.Location = new System.Drawing.Point(366, 91);
            this.updateContact_button.Name = "updateContact_button";
            this.updateContact_button.Size = new System.Drawing.Size(102, 23);
            this.updateContact_button.TabIndex = 16;
            this.updateContact_button.Text = "Update Contact";
            this.updateContact_button.UseVisualStyleBackColor = true;
            this.updateContact_button.Click += new System.EventHandler(this.UpdateContact_button_Click);
            // 
            // notes_txtbox
            // 
            this.notes_txtbox.Location = new System.Drawing.Point(47, 381);
            this.notes_txtbox.Multiline = true;
            this.notes_txtbox.Name = "notes_txtbox";
            this.notes_txtbox.Size = new System.Drawing.Size(298, 57);
            this.notes_txtbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Notes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone 1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // website_txtbox
            // 
            this.website_txtbox.Location = new System.Drawing.Point(23, 353);
            this.website_txtbox.Name = "website_txtbox";
            this.website_txtbox.Size = new System.Drawing.Size(322, 20);
            this.website_txtbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Company Website";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email_txtbox
            // 
            this.email_txtbox.Location = new System.Drawing.Point(23, 156);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(322, 20);
            this.email_txtbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // companyName_txtbox
            // 
            this.companyName_txtbox.Location = new System.Drawing.Point(23, 112);
            this.companyName_txtbox.Name = "companyName_txtbox";
            this.companyName_txtbox.Size = new System.Drawing.Size(322, 20);
            this.companyName_txtbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastName_txtbox
            // 
            this.lastName_txtbox.Location = new System.Drawing.Point(176, 34);
            this.lastName_txtbox.Name = "lastName_txtbox";
            this.lastName_txtbox.Size = new System.Drawing.Size(169, 20);
            this.lastName_txtbox.TabIndex = 3;
            this.lastName_txtbox.TextChanged += new System.EventHandler(this.CreateFullName);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // firstName_txtbox
            // 
            this.firstName_txtbox.Location = new System.Drawing.Point(9, 34);
            this.firstName_txtbox.Name = "firstName_txtbox";
            this.firstName_txtbox.Size = new System.Drawing.Size(153, 20);
            this.firstName_txtbox.TabIndex = 1;
            this.firstName_txtbox.TextChanged += new System.EventHandler(this.CreateFullName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // importContacts_button
            // 
            this.importContacts_button.Location = new System.Drawing.Point(12, 365);
            this.importContacts_button.Name = "importContacts_button";
            this.importContacts_button.Size = new System.Drawing.Size(89, 23);
            this.importContacts_button.TabIndex = 21;
            this.importContacts_button.Text = "Import Contacts";
            this.importContacts_button.UseVisualStyleBackColor = true;
            this.importContacts_button.Click += new System.EventHandler(this.ImportContacts_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.importContacts_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ContactDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Address Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactDetails_FormClosing);
            this.Load += new System.EventHandler(this.ContactDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteContact_button;
        private System.Windows.Forms.Button addContact_button;
        private System.Windows.Forms.Button updateContact_button;
        private System.Windows.Forms.TextBox notes_txtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox website_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companyName_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox fullName_txtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button importContacts_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox phone4_txtbox;
        private System.Windows.Forms.MaskedTextBox phone3_txtbox;
        private System.Windows.Forms.MaskedTextBox phone2_txtbox;
        private System.Windows.Forms.MaskedTextBox phone1_txtbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.Button button1;
    }
}

