using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressManagementSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string path = "CaseData.csv";
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] strData;
            string strLine;
            bool fileExists = System.IO.File.Exists(path);
            if (fileExists)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(
                                                path,
                                                System.Text.Encoding.Default);
                while (sr.Peek()>=0)
                {
                    strLine = sr.ReadLine();
                    strData = strLine.Split(delimiter);
                    caseList.DataTableCaseList.AddDataTableCaseListRow(
                                                strData[0],
                                                strData[1],
                                                strData[2],
                                                strData[3]);
                }
                sr.Close();
            }

            int NumberOfCases;

            NumberOfCases = dataGridViewCaseList.Rows.Count;
            NumberOfCases--;

            textBoxNumberOfCases.Text = "　表示件数：　" + NumberOfCases.ToString();
        
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<User> users = SelectUsers();

            foreach (User user in users)
            {
                comboBox1.Items.Add($"ID : { user.Id.ToString() }, Name : { user.Name }");
//                Console.WriteLine($"ID : { user.Id.ToString() }, Name : { user.Name }");
            }
 

        }

        private MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection("Database=progressmanagementsystem;Data Source=127.0.0.1;User Id=root;");
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            return con;
        }

        public List<User> SelectUsers()
        {
            MySqlConnection con = GetConnection();
            if (con == null) return null;

            // SQL作成
            string sql = "select * from user";

            // 取得
            List<User> users = null;
            try
            {
                users = con.Query<User>(sql).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                con.Close();
                return null;
            }

            // 切断
            con.Close();

            foreach (User user in users)
            {
//                Console.WriteLine($"ID : { user.Id.ToString() }, Name : { user.Name }");

             Console.WriteLine($"ID : { user.Id.ToString() }, Name : { user.Name }, Group : {user.Group}, Email : {user.Email}" );
            }

            return users;
        }



        public bool InsertUser(User user)
        {
            MySqlConnection con = GetConnection();
            if (con == null) return false;

            try
            {
                con.Execute("insert into user values (@Id, @Name) on duplicate key update name=@Name", user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }



        private void buttonCaseReceived_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxCaseReceived.Text = Today.ToString("yyyy/MM/dd");
        }

        private void buttonMeeting_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxMeeting.Text = Today.ToString("yyyy/MM/dd");
        }

        private void buttonSupplementReceived_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxSupplementReceived.Text = Today.ToString("yyyy/MM/dd");
        }

        private void buttonDraftDeadline_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxDraftDeadline.Text = Today.ToString("yyyy/MM/dd");
        }

        private void buttonDraftSent_Click(object sender, EventArgs e)
        {
            DateTime Today;
            DateTime x, y;
            TimeSpan DraftTerm;

            Today = monthCalendar.SelectionStart;
            textBoxDraftSent.Text = Today.ToString("yyyy/MM/dd");

            x = DateTime.Parse(textBoxMeeting.Text);
            y = DateTime.Parse(textBoxDraftSent.Text);

            DraftTerm = y - x;

            textBoxDraftTerm.Text = DraftTerm.ToString("dd");

        }

        private void linkLabelCaseThread_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.co.jp");
        }

        private void linkLabelClientInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.co.jp");
        }

        private void linkLabelElectricalWrapper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.co.jp");
        }

        private void linkLabelElectricalLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.co.jp");
        }
    }
}
