//NuGetパッケージ
using Dapper;
//NuGetパッケージ
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
            //終了ボタンでアプリ終了
            this.Close();
        }

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            //更新ボタンでデータ読み込み
            LoadData();
        }

        public void LoadData()
        {
            //仮のcsvからデータ読み込み
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

            //件数カウント＆表示
            int NumberOfCases;

            NumberOfCases = dataGridViewCaseList.Rows.Count;
            NumberOfCases--;

            textBoxNumberOfCases.Text = "　表示件数：　" + NumberOfCases.ToString();
        
        }

        //アプリ起動時
        private void FormMain_Load(object sender, EventArgs e)
        {
            //データベースのuserテーブルを読み込んでusersインスタンスにマッピング
            List<User> users = SelectUsers();

            //usersを担当者コンボボックスに追加
            foreach (User user in users)
            {
                comboBoxEngineer.Items.Add(user.Name.ToString());
//                comboBox1.Items.Add($"ID : { user.Id.ToString() }, Name : { user.Name }");
                Console.WriteLine($"ID : { user.Id.ToString() }, Name : { user.Name }");
            }

            //データベースのcaseテーブルを読み込んでcasesインスタンスにマッピング
            List<Case> cases = SelectCases();

            Console.WriteLine(cases[1].CaseNumber.ToString());

        }

        //データベース接続
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

        //データベースのuserテーブルを読み込んでusersインスタンスにマッピング
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

            return users;
        }

        //データベースのuserテーブルの更新・追記
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

        //データベースのcaseテーブルを読み込んでcasesインスタンスにマッピング
        public List<Case> SelectCases()
        {
            MySqlConnection con = GetConnection();
            if (con == null) return null;

            // SQL作成
            string sql = "select * from case";

            // 取得
            List<Case> cases = null;
            try
            {
               cases = con.Query<Case>(sql).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                con.Close();
                return null;
            }

            // 切断
            con.Close();

            return cases;
        }


        //受託日入力
        private void buttonCaseReceived_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxCaseReceived.Text = Today.ToString("yyyy/MM/dd");
        }

        //面談日入力
        private void buttonMeeting_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxMeeting.Text = Today.ToString("yyyy/MM/dd");
        }

        //補充資料受領日入力
        private void buttonSupplementReceived_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxSupplementReceived.Text = Today.ToString("yyyy/MM/dd");
        }

        //ドラフト期限日入力
        private void buttonDraftDeadline_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxDraftDeadline.Text = Today.ToString("yyyy/MM/dd");
        }

        //ドラフト送付日入力
        private void buttonDraftSent_Click(object sender, EventArgs e)
        {
            DateTime Today;
            DateTime x, y;
            TimeSpan DraftDays;

            Today = monthCalendar.SelectionStart;
            textBoxDraftSent.Text = Today.ToString("yyyy/MM/dd");

            x = DateTime.Parse(textBoxMeeting.Text);
            y = DateTime.Parse(textBoxDraftSent.Text);

            DraftDays = y - x;

            textBoxDraftDays.Text = DraftDays.ToString("dd");

        }

        //スレッドリンク
        private void linkLabelCaseThread_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.co.jp");
        }

        //クライアント情報リンク
        private void linkLabelClientInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.co.jp");
        }

        //Wrapperリンク
        private void linkLabelElectricalWrapper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.co.jp");
        }

        //Roosterリンク
        private void linkLabelElectricalLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.co.jp");
        }

        //データグリッドビューセル選択
        private void dataGridViewCaseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
        }
    }
}
