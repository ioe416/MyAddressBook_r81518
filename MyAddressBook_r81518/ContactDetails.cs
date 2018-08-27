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

namespace MyAddressBook_r81518
{
    public partial class ContactDetails : Form
    {
        public ContactDetails()
        {
            InitializeComponent();
        }
        List<Contact> person = new List<Contact>();
        private Microsoft.Office.Interop.Excel.Application xlApp;
        private Workbook xlWorkBook;
        private Worksheet xlWorkSheet;

        public string firstName;
        public string lastName;
        public string fullName;
        public string companyName;
        public string email;
        public string companyWebsite;
        public string companyPhone;
        public string mobilePhone;
        public string notes;

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //listView1.View = View.Details;
            //listView1.HeaderStyle = ColumnHeaderStyle.None;

            if (!Directory.Exists(path + "\\Address Book"))
                Directory.CreateDirectory(path + "\\Address Book");
            if (!File.Exists(path + "\\Address Book\\settings.xml"))
            {
                XmlTextWriter xw = new XmlTextWriter(path + "\\Address Book\\settings.xml", Encoding.UTF8);
                xw.WriteStartElement("Contacts");
                xw.WriteEndElement();
                xw.Close();
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Address Book\\settings.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("Contacts/Person"))
            {
                Contact p = new Contact
                {
                    FirstName = xNode.SelectSingleNode("FirstName").InnerText,
                    LastName = xNode.SelectSingleNode("LastName").InnerText,
                    FullName = xNode.SelectSingleNode("FullName").InnerText,
                    CompanyName = xNode.SelectSingleNode("CompanyName").InnerText,
                    CompanyWebsite = xNode.SelectSingleNode("Website").InnerText,
                    Email = xNode.SelectSingleNode("Email").InnerText,
                    CompanyPhone = xNode.SelectSingleNode("CompanyPhone").InnerText,
                    MobilePhone = xNode.SelectSingleNode("MobilePhone").InnerText,
                    Notes = xNode.SelectSingleNode("Notes").InnerText
                };
                person.Add(p);

                listView1.Items.Add(p.FirstName + " " + p.LastName);
            }

        }

        private void AddContact_button_Click(object sender, EventArgs e)
        {
            Contact p = new Contact
            {
                FirstName = firstName_txtbox.Text,
                LastName = lastName_txtbox.Text,
                FullName = fullName_txtbox.Text,
                CompanyName = companyName_txtbox.Text,
                Email = email_txtbox.Text,
                CompanyWebsite = website_txtbox.Text,
                CompanyPhone = phone1_txtbox.Text,
                MobilePhone = phone2_txtbox.Text,
                Notes = notes_txtbox.Text
            };
            person.Add(p);
            listView1.Items.Add(p.FirstName + " " + p.LastName);

            Clear_TextBoxes();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                firstName_txtbox.Text = person[listView1.SelectedItems[0].Index].FirstName;
                lastName_txtbox.Text = person[listView1.SelectedItems[0].Index].LastName;
                fullName_txtbox.Text = person[listView1.SelectedItems[0].Index].FullName;
                companyName_txtbox.Text = person[listView1.SelectedItems[0].Index].CompanyName;
                email_txtbox.Text = person[listView1.SelectedItems[0].Index].Email;
                website_txtbox.Text = person[listView1.SelectedItems[0].Index].CompanyWebsite;
                phone1_txtbox.Text = person[listView1.SelectedItems[0].Index].CompanyPhone;
                phone2_txtbox.Text = person[listView1.SelectedItems[0].Index].MobilePhone;
                notes_txtbox.Text = person[listView1.SelectedItems[0].Index].Notes;

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
                person.RemoveAt(listView1.SelectedItems[0].Index);
                Clear_TextBoxes();
                listView1.Items.Remove(listView1.SelectedItems[0]);                
            }
            catch
            {

            }
        }

        private void UpdateContact_button_Click(object sender, EventArgs e)
        {
            person[listView1.SelectedItems[0].Index].FirstName = firstName_txtbox.Text;
            person[listView1.SelectedItems[0].Index].LastName = lastName_txtbox.Text;
            person[listView1.SelectedItems[0].Index].FullName = fullName_txtbox.Text;
            person[listView1.SelectedItems[0].Index].CompanyName = companyName_txtbox.Text;
            person[listView1.SelectedItems[0].Index].Email = email_txtbox.Text;
            person[listView1.SelectedItems[0].Index].CompanyWebsite = website_txtbox.Text;
            person[listView1.SelectedItems[0].Index].CompanyPhone = phone1_txtbox.Text;
            person[listView1.SelectedItems[0].Index].MobilePhone = phone2_txtbox.Text;
            person[listView1.SelectedItems[0].Index].Notes = notes_txtbox.Text;
            listView1.SelectedItems[0].Text = fullName_txtbox.Text;

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
            XmlDocument xDoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            xDoc.Load(path + "\\Address Book\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("Contacts");
            xNode.RemoveAll();

            foreach (Contact p in person)
            {
                XmlNode xTop = xDoc.CreateElement("Person");
                XmlNode xFirstName = xDoc.CreateElement("FirstName");
                XmlNode xLastName = xDoc.CreateElement("LastName");
                XmlNode xFullName = xDoc.CreateElement("FullName");
                XmlNode xCompanyName = xDoc.CreateElement("CompanyName");
                XmlNode xCompanyWebsite = xDoc.CreateElement("Website");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xCompanyPhone = xDoc.CreateElement("CompanyPhone");
                XmlNode xMobilePhone = xDoc.CreateElement("MobilePhone");
                XmlNode xNotes = xDoc.CreateElement("Notes");

                xFirstName.InnerText = p.FirstName;
                xLastName.InnerText = p.LastName;
                xFullName.InnerText = p.FullName;
                xCompanyName.InnerText = p.CompanyName;
                xCompanyWebsite.InnerText = p.CompanyWebsite;
                xEmail.InnerText = p.Email;
                xCompanyPhone.InnerText = p.CompanyPhone;
                xMobilePhone.InnerText = p.MobilePhone;
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
                xDoc.DocumentElement.AppendChild(xTop);
            }
            xDoc.Save(path + "\\Address Book\\settings.xml");
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
                    CompanyPhone = Convert.ToString(xlWorksheet.Cells[i, 5].Value),
                    MobilePhone = Convert.ToString(xlWorksheet.Cells[i, 7].Value),
                    Notes = Convert.ToString(xlWorksheet.Cells[i, 8].Value)
                };
                person.Add(p);
                listView1.Items.Add(p.FirstName + " " + p.LastName);
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
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label14.Visible = true;
            phone3_txtbox.Visible = true;
            comboBox3.Visible = true;
        }

        private void Label14_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            phone4_txtbox.Visible = true;
            comboBox4.Visible = true;
        }
    }
    class Contact
    {
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
        public string CompanyPhone
        {
            set;
            get;
        }
        public string MobilePhone
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

}
