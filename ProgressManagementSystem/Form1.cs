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

        //終了ボタン、アプリ終了
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //更新ボタン、現時点では不使用
        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            //仮csvからのデータ読み込み
            //LoadData();

        }


        /*不使用メソッド。仮csvからのデータ読み込み
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
        */


        //アプリ起動時、DBからデータ読み込み
        private void FormMain_Load(object sender, EventArgs e)
        {
            //DBのuserテーブルを読み込んでusersインスタンスにマッピング
            List<User> users = SelectUsers();
            //担当者コンボボックスに追加
            foreach (User user in users)
            {
                comboBoxEngineer.Items.Add(user.Name.ToString());
                //                comboBox1.Items.Add($"ID : { user.Id.ToString() }, Name : { user.Name }");
            }

            //DBのcaseテーブルを読み込んでcasesインスタンスにマッピング
            List<Case> cases = SelectCases();
            //データグリッドビュー表示、ケース番号、クライアント名、クライアント整理番号、期限
            foreach (Case @case in cases)
            {
                caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
            }
            //初期選択セルに対応する受託日表示
            textBoxCaseReceived.Text = cases[0].CaseReceived.ToShortDateString();
            //初期選択セルに対応する面談日表示
            textBoxMeeting.Text = cases[0].Meeting.ToShortDateString();
            //初期選択セルに対応する補充資料受領日表示
            textBoxSupplementReceived.Text = cases[0].SupplementReceived.ToShortDateString();
            //初期選択セルに対応する初稿期限日表示
            textBoxDraftDeadline.Text = cases[0].DraftDeadline.ToShortDateString();
            //初期選択セルに対応する初稿送付日表示
            textBoxDraftSent.Text = cases[0].DraftSent.ToShortDateString();
            //初期選択セルに対応するドラフト日数表示
            textBoxDraftDays.Text = cases[0].DraftDays.ToString();
            //初期選択セルに対応するメモ表示
            textBoxNote.Text = cases[0].Note.ToString();

        }

        //データグリッドビューセル選択時
        private void dataGridViewCaseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int LawNumber = e.RowIndex;
            
            Console.WriteLine(LawNumber);

            //DBのcaseテーブルを読み込んでcasesインスタンスにマッピング
            List<Case> cases = SelectCases();
            //受託日表示
            textBoxCaseReceived.Text = cases[LawNumber].CaseReceived.ToShortDateString();
            //面談日表示
            textBoxMeeting.Text = cases[LawNumber].Meeting.ToShortDateString();
            //補充資料受領日表示
            textBoxSupplementReceived.Text = cases[LawNumber].SupplementReceived.ToShortDateString();
            //初稿期限日表示
            textBoxDraftDeadline.Text = cases[LawNumber].DraftDeadline.ToShortDateString(); 
            //初稿送付日表示
            textBoxDraftSent.Text = cases[LawNumber].DraftSent.ToShortDateString();
            //ドラフト日数表示
            textBoxDraftDays.Text = cases[LawNumber].DraftDays.ToString();
            //メモ表示
            textBoxNote.Text = cases[LawNumber].Note.ToString();

        }

        //保存ボタン、DBのcaseテーブルに保存
        private void buttonStore_Click(object sender, EventArgs e)
        {
            List<Case> cases = SelectCases();

            Case case2 = new Case();

            case2.CaseNumber = "JP22-0001";
            case2.ClientReference = "JP0001";
            case2.ClientName = "xxx";
            case2.Contact = "新居";
            case2.Engineer = "久村";
            case2.ClientContact = "xxx";
            case2.Inventor = "xxx";
            case2.Flag = "管理中";
            case2.Category = "出願";
            case2.Region = "国内";
            case2.DueDate = DateTime.Parse("2022/03/15");
            case2.Thread = "xxx";
            case2.Wrapper = "xxx";
            case2.Rooster = "xxx";
            case2.CaseReceived = DateTime.Parse("2022/01/15");
            case2.Meeting = DateTime.Parse("2022/01/22");
            case2.SupplementReceived = DateTime.Parse("2022/01/23");
            case2.DraftDeadline = DateTime.Parse("2022/02/23");
            case2.DraftSent = DateTime.Parse("2022/02/21");
            case2.DraftDays = 30;
            case2.FiledDate = DateTime.Parse("2022/04/25");
            case2.Note = "Note1";

            Console.WriteLine(case2.CaseNumber.ToString());
            Console.WriteLine(case2.ClientReference.ToString());
            Console.WriteLine(case2.ClientName.ToString());
            Console.WriteLine(case2.Contact.ToString());
            Console.WriteLine(case2.Engineer.ToString());
            Console.WriteLine(case2.ClientContact.ToString());
            Console.WriteLine(case2.Inventor.ToString());
            Console.WriteLine(case2.Flag.ToString());
            Console.WriteLine(case2.Category.ToString());
            Console.WriteLine(case2.Region.ToString());
            Console.WriteLine(case2.DueDate.ToString());
            Console.WriteLine(case2.Thread.ToString());
            Console.WriteLine(case2.Wrapper.ToString());
            Console.WriteLine(case2.Rooster.ToString());
            Console.WriteLine(case2.CaseReceived.ToString());
            Console.WriteLine(case2.Meeting.ToString());
            Console.WriteLine(case2.SupplementReceived.ToString());
            Console.WriteLine(case2.DraftDeadline.ToString());
            Console.WriteLine(case2.DraftSent.ToString());
            Console.WriteLine(case2.DraftDays.ToString());
            Console.WriteLine(case2.FiledDate.ToString());
            Console.WriteLine(case2.Note.ToString());

            InsertCase(case2);

        }

        //DB接続
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

        //DBのuserテーブルを読み込んでusersインスタンスにマッピング
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

        //DBのuserテーブルの更新・追記
        public bool InsertUser(User user)
        {
            MySqlConnection con = GetConnection();
            if (con == null) return false;

            try
            {
                con.Execute("insert into user values (@Id, @Name, @Group, @Email) on duplicate key update name=@Name, `group`=@Group, email=@Email", user);
//                con.Execute("insert into user values (@Id, @Name) on duplicate key update name=@Name", user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        //DBのcaseテーブルを読み込んでcasesインスタンスにマッピング
        public List<Case> SelectCases()
        {
            MySqlConnection con = GetConnection();
            if (con == null) return null;

            // SQL作成（caseがMySQLの予約語なのでをバッククォートで囲んでいる）
            string sql = "select * from `case`";

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


        //DBのcaseテーブルの更新・追記
        public bool InsertCase(Case @case)
        {
            MySqlConnection con = GetConnection();
            if (con == null) return false;

            try
            {
                con.Execute("insert into `case` values (@CaseNumber, @ClientReference, @ClientName," +
                    " @Contact, @Engineer, @ClientContact, @Inventor, @Flag, @Category, @Region, @DueDate," +
                    " @Thread, @Wrapper, @Rooster, @CaseReceived, @Meeting, @SupplementReceived, @DraftDeadline," +
                    " @DraftSent, @DraftDays, @FiledDate, @Note)" +
                    " on duplicate key update clientreference=@ClientReference, clientname=@ClientName, contact=@Contact," +
                    " engineer=@Engineer, clientcontact=@ClientContact, inventor=@Inventor, flag=@Flag, category=@Category," +
                    " region=@Region, duedate=@DueDate, thread=@Thread, wrapper=@Wrapper, rooster=@Rooster, casereceived=@CaseReceived," +
                    " meeting=@Meeting, supplementreceived=@SupplementReceived, draftdeadline=@DraftDeadline, draftdays=@DraftDays," +
                    " draftSent=@DraftSent, fileddate=@FiledDate, note=@Note", @case);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        //受託日入力
        private void buttonCaseReceived_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxCaseReceived.Text = Today.ToShortDateString();
        }

        //面談日入力
        private void buttonMeeting_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxMeeting.Text = Today.ToShortDateString();
        }

        //補充資料受領日入力
        private void buttonSupplementReceived_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxSupplementReceived.Text = Today.ToShortDateString(); 
        }

        //ドラフト期限日入力
        private void buttonDraftDeadline_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxDraftDeadline.Text = Today.ToShortDateString();
        }

        //ドラフト送付日入力、ドラフト日数計算
        private void buttonDraftSent_Click(object sender, EventArgs e)
        {
            DateTime Today;
            DateTime x, y;
            TimeSpan DraftDays;

            Today = monthCalendar.SelectionStart;
            textBoxDraftSent.Text = Today.ToShortDateString();

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

    }
}
