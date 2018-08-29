using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MyAddressBook_r81518
{
    public partial class ContactDetails : Form
    {
        public ContactDetails()
        {
            InitializeComponent();
        }
        List<Contact> personalCompany = new List<Contact>();
        List<Contact> personalName = new List<Contact>();
        List<Contact> professionalCompany = new List<Contact>();
        List<Contact> professionalName = new List<Contact>();
        List<Contact> professional = new List<Contact>();
        List<Contact> personal = new List<Contact>();

        private Microsoft.Office.Interop.Excel.Application xlApp;
        private Workbook xlWorkBook;
        private Worksheet xlWorkSheet;

        public string book;
        public string firstName;
        public string lastName;
        public string fullName;
        public string companyName;
        public string email;
        public string companyWebsite;
        public string phone1;
        public string extention1;
        public string phoneType1;
        public string phone2;
        public string extention2;
        public string phoneType2;
        public string phone3;
        public string extention3;
        public string phoneType3;
        public string phone4;
        public string extention4;
        public string phoneType4;
        public string notes;

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            pro_comp_listview.View = View.Details;
            pro_comp_listview.HeaderStyle = ColumnHeaderStyle.None;
            pro_name_listview.View = View.Details;
            pro_name_listview.HeaderStyle = ColumnHeaderStyle.None;
            per_comp_listview.View = View.Details;
            per_comp_listview.HeaderStyle = ColumnHeaderStyle.None;
            per_name_listview.View = View.Details;
            per_name_listview.HeaderStyle = ColumnHeaderStyle.None;

            if (!Directory.Exists(path + "\\Address Book"))
                Directory.CreateDirectory(path + "\\Address Book");

            if (!File.Exists(path + "\\Address Book\\professional.xml"))
            {
                XmlTextWriter xw = new XmlTextWriter(path + "\\Address Book\\professional.xml", Encoding.UTF8);
                xw.WriteStartElement("Contacts");
                xw.WriteEndElement();
                xw.Close();
            }
            XmlDocument professionalDoc = new XmlDocument();
            professionalDoc.Load(path + "\\Address Book\\professional.xml");
            foreach (XmlNode xNode in professionalDoc.SelectNodes("Contacts/Person"))
            {
                Contact p = new Contact
                {
                    FirstName = xNode.SelectSingleNode("FirstName").InnerText,
                    LastName = xNode.SelectSingleNode("LastName").InnerText,
                    FullName = xNode.SelectSingleNode("FullName").InnerText,
                    CompanyName = xNode.SelectSingleNode("CompanyName").InnerText,
                    CompanyWebsite = xNode.SelectSingleNode("Website").InnerText,
                    Email = xNode.SelectSingleNode("Email").InnerText,
                    Phone1 = xNode.SelectSingleNode("CompanyPhone").InnerText,
                    Phone2 = xNode.SelectSingleNode("MobilePhone").InnerText,
                    Notes = xNode.SelectSingleNode("Notes").InnerText
                };
                professional.Add(p);
                pro_comp_listview.Items.Add(p.CompanyName);
                pro_name_listview.Items.Add(p.FirstName + " " + p.LastName);
            }

            if (!File.Exists(path + "\\Address Book\\personal.xml"))
            {
                XmlTextWriter xw = new XmlTextWriter(path + "\\Address Book\\personal.xml", Encoding.UTF8);
                xw.WriteStartElement("Contacts");
                xw.WriteEndElement();
                xw.Close();
            }
            XmlDocument personalDoc = new XmlDocument();
            personalDoc.Load(path + "\\Address Book\\personal.xml");
            foreach (XmlNode xNode in personalDoc.SelectNodes("Contacts/Person"))
            {
                Contact p = new Contact
                {
                    FirstName = xNode.SelectSingleNode("FirstName").InnerText,
                    LastName = xNode.SelectSingleNode("LastName").InnerText,
                    FullName = xNode.SelectSingleNode("FullName").InnerText,
                    CompanyName = xNode.SelectSingleNode("CompanyName").InnerText,
                    CompanyWebsite = xNode.SelectSingleNode("Website").InnerText,
                    Email = xNode.SelectSingleNode("Email").InnerText,
                    Phone1 = xNode.SelectSingleNode("CompanyPhone").InnerText,
                    Phone2 = xNode.SelectSingleNode("MobilePhone").InnerText,
                    Notes = xNode.SelectSingleNode("Notes").InnerText
                };
                personal.Add(p);
                per_comp_listview.Items.Add(p.CompanyName);
                per_name_listview.Items.Add(p.FirstName + " " + p.LastName);
            }

        }

        private void AddContact_button_Click(object sender, EventArgs e)
        {
            Contact p = new Contact
            {
                Book = book,
                FirstName = firstName_txtbox.Text,
                LastName = lastName_txtbox.Text,
                FullName = fullName_txtbox.Text,
                CompanyName = companyName_txtbox.Text,
                Email = email_txtbox.Text,
                CompanyWebsite = website_txtbox.Text,
                Phone1 = phone1_txtbox.Text,
                PhoneType1 = comboBox1.Text,
                Extention1 = ext1.Text,
                Phone2 = phone2_txtbox.Text,
                PhoneType2 = comboBox2.Text,
                Extention2 = ext2.Text,
                Phone3 = phone3_txtbox.Text,
                PhoneType3 = comboBox3.Text,
                Extention3 = ext3.Text,
                Phone4 = phone4_txtbox.Text,
                PhoneType4 = comboBox4.Text,
                Extention4 = ext4.Text,
                Notes = notes_txtbox.Text
            };
            personalCompany.Add(p);
            pro_comp_listview.Items.Add(p.FirstName + " " + p.LastName);

            Clear_TextBoxes();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pro_comp_listview.SelectedItems.Count > 0)
            {
                firstName_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].FirstName;
                lastName_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].LastName;
                fullName_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].FullName;
                companyName_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].CompanyName;
                email_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].Email;
                website_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].CompanyWebsite;
                phone1_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].Phone1;
                phone2_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].Phone2;
                notes_txtbox.Text = personalCompany[pro_comp_listview.SelectedItems[0].Index].Notes;

            }
            else
            {
                return;
            }
            
        }

        private void DeleteContact_button_Click(object sender, EventArgs e)
        {
            try
            {
                personalCompany.RemoveAt(pro_comp_listview.SelectedItems[0].Index);
                personalCompany.RemoveAt(pro_name_listview.SelectedItems[0].Index);
                Clear_TextBoxes();
                pro_comp_listview.Items.Remove(pro_comp_listview.SelectedItems[0]);
                pro_name_listview.Items.Remove(pro_name_listview.SelectedItems[0]);
            }
            catch
            {

            }
        }

        private void UpdateContact_button_Click(object sender, EventArgs e)
        {
            personalCompany[pro_comp_listview.SelectedItems[0].Index].FirstName = firstName_txtbox.Text;
            personalCompany[pro_comp_listview.SelectedItems[0].Index].LastName = lastName_txtbox.Text;
            personalCompany[pro_comp_listview.SelectedItems[0].Index].FullName = fullName_txtbox.Text;
            personalCompany[pro_comp_listview.SelectedItems[0].Index].CompanyName = companyName_txtbox.Text;
            personalCompany[pro_comp_listview.SelectedItems[0].Index].Email = email_txtbox.Text;
            personalCompany[pro_comp_listview.SelectedItems[0].Index].CompanyWebsite = website_txtbox.Text;
            personalCompany[pro_comp_listview.SelectedItems[0].Index].Phone1 = phone1_txtbox.Text;
            personalCompany[pro_comp_listview.SelectedItems[0].Index].Phone2 = phone2_txtbox.Text;
            personalCompany[pro_comp_listview.SelectedItems[0].Index].Notes = notes_txtbox.Text;
            pro_comp_listview.SelectedItems[0].Text = fullName_txtbox.Text;

            Clear_TextBoxes();

        }

        private void Clear_TextBoxes()
        {
            firstName_txtbox.Clear();
            lastName_txtbox.Clear();
            fullName_txtbox.Clear();
            companyName_txtbox.Clear();
            email_txtbox.Clear();
            website_txtbox.Clear();
            phone1_txtbox.Clear();
            phone2_txtbox.Clear();
            notes_txtbox.Clear();
        }

        private void ContactDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument personalDoc = new XmlDocument();
            XmlDocument professionalDoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            personalDoc.Load(path + "\\Address Book\\personal.xml");
            professionalDoc.Load(path + "\\Address Book\\professional.xml");
            XmlNode xNode = personalDoc.SelectSingleNode("Contacts");
            XmlNode yNode = professionalDoc.SelectSingleNode("Contacts");
            xNode.RemoveAll();

            foreach (Contact p in personal)
            {
                XmlNode xTop = personalDoc.CreateElement("Person");
                XmlNode xFirstName = personalDoc.CreateElement("FirstName");
                XmlNode xLastName = personalDoc.CreateElement("LastName");
                XmlNode xFullName = personalDoc.CreateElement("FullName");
                XmlNode xCompanyName = personalDoc.CreateElement("CompanyName");
                XmlNode xCompanyWebsite = personalDoc.CreateElement("Website");
                XmlNode xEmail = personalDoc.CreateElement("Email");
                XmlNode xCompanyPhone = personalDoc.CreateElement("CompanyPhone");
                XmlNode xMobilePhone = personalDoc.CreateElement("MobilePhone");
                XmlNode xNotes = personalDoc.CreateElement("Notes");

                xFirstName.InnerText = p.FirstName;
                xLastName.InnerText = p.LastName;
                xFullName.InnerText = p.FullName;
                xCompanyName.InnerText = p.CompanyName;
                xCompanyWebsite.InnerText = p.CompanyWebsite;
                xEmail.InnerText = p.Email;
                xCompanyPhone.InnerText = p.Phone1;
                xMobilePhone.InnerText = p.Phone2;
                xNotes.InnerText = p.Notes;
                xTop.AppendChild(xFirstName);
                xTop.AppendChild(xLastName);
                xTop.AppendChild(xFullName);
                xTop.AppendChild(xCompanyName);
                xTop.AppendChild(xCompanyWebsite);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xCompanyPhone);
                xTop.AppendChild(xMobilePhone);
                xTop.AppendChild(xNotes);
                personalDoc.DocumentElement.AppendChild(xTop);
            }
            personalDoc.Save(path + "\\Address Book\\personal.xml");
            foreach (Contact p in professional)
            {
                XmlNode xTop = professionalDoc.CreateElement("Person");
                XmlNode xFirstName = professionalDoc.CreateElement("FirstName");
                XmlNode xLastName = professionalDoc.CreateElement("LastName");
                XmlNode xFullName = professionalDoc.CreateElement("FullName");
                XmlNode xCompanyName = professionalDoc.CreateElement("CompanyName");
                XmlNode xCompanyWebsite = professionalDoc.CreateElement("Website");
                XmlNode xEmail = professionalDoc.CreateElement("Email");
                XmlNode xCompanyPhone = professionalDoc.CreateElement("CompanyPhone");
                XmlNode xMobilePhone = professionalDoc.CreateElement("MobilePhone");
                XmlNode xNotes = professionalDoc.CreateElement("Notes");

                xFirstName.InnerText = p.FirstName;
                xLastName.InnerText = p.LastName;
                xFullName.InnerText = p.FullName;
                xCompanyName.InnerText = p.CompanyName;
                xCompanyWebsite.InnerText = p.CompanyWebsite;
                xEmail.InnerText = p.Email;
                xCompanyPhone.InnerText = p.Phone1;
                xMobilePhone.InnerText = p.Phone2;
                xNotes.InnerText = p.Notes;
                xTop.AppendChild(xFirstName);
                xTop.AppendChild(xLastName);
                xTop.AppendChild(xFullName);
                xTop.AppendChild(xCompanyName);
                xTop.AppendChild(xCompanyWebsite);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xCompanyPhone);
                xTop.AppendChild(xMobilePhone);
                xTop.AppendChild(xNotes);
                professionalDoc.DocumentElement.AppendChild(xTop);
            }
            professionalDoc.Save(path + "\\Address Book\\professional.xml");
        }

        private void ImportContacts_button_Click(object sender, EventArgs e)
        {
            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Excel File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }


            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                Contact p = new Contact
                {
                    FirstName = Convert.ToString(xlWorksheet.Cells[i, 2].Value),
                    LastName = Convert.ToString(xlWorksheet.Cells[i, 3].Value),
                    FullName = Convert.ToString(xlWorksheet.Cells[i, 2].Value) + " " + Convert.ToString(xlWorksheet.Cells[i, 3].Value),
                    CompanyName = Convert.ToString(xlWorksheet.Cells[i, 1].Value),
                    Email = Convert.ToString(xlWorksheet.Cells[i, 9].Value),
                    CompanyWebsite = Convert.ToString(xlWorksheet.Cells[i, 10].Value),
                    Phone1 = Convert.ToString(xlWorksheet.Cells[i, 5].Value),
                    Phone2 = Convert.ToString(xlWorksheet.Cells[i, 7].Value),
                    Notes = Convert.ToString(xlWorksheet.Cells[i, 8].Value)
                };
                personalCompany.Add(p);
                pro_comp_listview.Items.Add(p.FirstName + " " + p.LastName);
            }

            //cleanup  
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:  
            //  never use two dots, all COM objects must be referenced and released individually  
            //  ex: [somthing].[something].[something] is bad  

            //release com objects to fully kill excel process from running in the background  
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release  
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release  
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void CreateFullName(object sender, EventArgs e)
        {
            fullName_txtbox.Text = firstName_txtbox.Text + " " + lastName_txtbox.Text;
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label13.Visible = true;
            phone2_txtbox.Visible = true;
            comboBox2.Visible = true;
            ext2.Visible = true;
            ext_label2.Visible = true;
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label14.Visible = true;
            phone3_txtbox.Visible = true;
            comboBox3.Visible = true;
            ext3.Visible = true;
            ext_label3.Visible = true;
        }

        private void Label14_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            phone4_txtbox.Visible = true;
            comboBox4.Visible = true;
            ext4.Visible = true;
            ext_label4.Visible = true;
        }

        private void MyCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox1.Checked == true)
            {
                contactType_label.Text = "Professional";
                book = "Professional";
            }
            else
            {
                contactType_label.Text = "Personal";
                book = "Personal";
            }
            
        }

        private void Pro_name_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pro_name_listview.SelectedItems.Count > 0)
            {
                firstName_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].FirstName;
                lastName_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].LastName;
                fullName_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].FullName;
                companyName_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].CompanyName;
                email_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].Email;
                website_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].CompanyWebsite;
                phone1_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].Phone1;
                phone2_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].Phone2;
                notes_txtbox.Text = personalCompany[pro_name_listview.SelectedItems[0].Index].Notes;

            }
            else
            {
                return;
            }
        }
    }
    class Contact
    {
        public string Book
        {
            set;
            get;
        }
        public string FirstName
        {
            set;
            get;
        }
        public string LastName
        {
            set;
            get;
        }
        public string FullName
        {
            set;
            get;
        }
        public string CompanyName
        {
            set;
            get;
        }
        public string Email
        {
            set;
            get;
        }
        public string CompanyWebsite
        {
            set;
            get;
        }
        public string Phone1
        {
            set;
            get;
        }
        public string Phone2
        {
            set;
            get;
        }
        public string Phone3
        {
            set;
            get;
        }
        public string Phone4
        {
            set;
            get;
        }
        public string Extention1
        {
            set;
            get;
        }
        public string Extention2
        {
            set;
            get;
        }
        public string Extention3
        {
            set;
            get;
        }
        public string Extention4
        {
            set;
            get;
        }
        public string PhoneType1
        {
            set;
            get;
        }
        public string PhoneType2
        {
            set;
            get;
        }
        public string PhoneType3
        {
            set;
            get;
        }
        public string PhoneType4
        {
            set;
            get;
        }
        public string Notes
        {
            set;
            get;
        }
    }


    public class MyCheckBox : System.Windows.Forms.CheckBox
    {
        public MyCheckBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Padding = new Padding(6);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = new GraphicsPath())
            {
                var d = Padding.All;
                var r = this.Height - 2 * d;
                path.AddArc(d, d, r, r, 90, 180);
                path.AddArc(this.Width - r - d, d, r, r, -90, 180);
                path.CloseFigure();
                e.Graphics.FillPath(Checked ? Brushes.DarkGray : Brushes.DodgerBlue, path);
                r = Height - 1;
                var rect = Checked ? new System.Drawing.Rectangle(Width - r - 1, 0, r, r)
                                   : new System.Drawing.Rectangle(0, 0, r, r);
                e.Graphics.FillEllipse(Checked ? Brushes.DarkGray : Brushes.DodgerBlue, rect);
            }
        }
    }

}
