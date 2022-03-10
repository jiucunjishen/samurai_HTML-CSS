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
        //Form1のメンバ変数
        //DBのuserテーブルを読み込んでマッピングするUserクラスのインスタンス
        private List<User> users;
        //DBのcaseテーブルを読み込んでマッピングするCaseクラスのインスタンス
        private List<Case> cases;
        //選択セルの行
        int RowNumber;

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


        //アプリ起動時、DBからデータ読み込み
        private void FormMain_Load(object sender, EventArgs e)
        {
            //DBのuserテーブルを読み込んでusersインスタンスにマッピング
            users = SelectUsers();
            //担当者コンボボックスに追加
            foreach (User user in users)
            {
                comboBoxEngineer.Items.Add(user.Name.ToString());
                //                comboBox1.Items.Add($"ID : { user.Id.ToString() }, Name : { user.Name }");
            }

            //DBのcaseテーブルを読み込んでcasesインスタンスにマッピング
            cases = SelectCases();
            //データグリッドビュー表示、ケース番号、クライアント名、クライアント整理番号、期限
            foreach (Case @case in cases)
            {
                caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
            }

            //件数カウント＆表示
            int NumberOfCases;

            NumberOfCases = dataGridViewCaseList.Rows.Count;
            NumberOfCases--;

            textBoxNumberOfCases.Text = "　表示件数：　" + NumberOfCases.ToString();

        }

        //データグリッドビューセル選択時
        private void dataGridViewCaseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowNumber = e.RowIndex;

            if (RowNumber >= 0)
            {
                //受託日表示
                textBoxCaseReceived.Text = cases[RowNumber].CaseReceived.ToShortDateString();
                //面談日表示
                textBoxMeeting.Text = cases[RowNumber].Meeting.ToShortDateString();
                //補充資料受領日表示
                textBoxSupplementReceived.Text = cases[RowNumber].SupplementReceived.ToShortDateString();
                //初稿期限日表示
                textBoxDraftDeadline.Text = cases[RowNumber].DraftDeadline.ToShortDateString();
                //初稿送付日表示
                textBoxDraftSent.Text = cases[RowNumber].DraftSent.ToShortDateString();
                //ドラフト日数表示
                textBoxDraftDays.Text = cases[RowNumber].DraftDays.ToString();
                //庁提出日表示
                textBoxFiledDate.Text = cases[RowNumber].FiledDate.ToShortDateString();
                //メモ表示
                textBoxNote.Text = cases[RowNumber].Note.ToString();

            }

        }

        //保存ボタン、DBのcaseテーブルに保存
        private void buttonStore_Click(object sender, EventArgs e)
        {

            foreach (Case @case in cases)
            {

                InsertCase(@case);
            }

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
            cases[RowNumber].CaseReceived = Today;
        }

        //面談日入力
        private void buttonMeeting_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxMeeting.Text = Today.ToShortDateString();
            cases[RowNumber].Meeting = Today;
        }

        //補充資料受領日入力
        private void buttonSupplementReceived_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxSupplementReceived.Text = Today.ToShortDateString();
            cases[RowNumber].SupplementReceived = Today;
        }

        //ドラフト期限日入力
        private void buttonDraftDeadline_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxDraftDeadline.Text = Today.ToShortDateString();
            cases[RowNumber].DraftDeadline = Today;
        }

        //ドラフト送付日入力、ドラフト日数計算
        private void buttonDraftSent_Click(object sender, EventArgs e)
        {
            DateTime Today;
            DateTime x, y;
            TimeSpan DraftDays;

            Today = monthCalendar.SelectionStart;
            textBoxDraftSent.Text = Today.ToShortDateString();
            cases[RowNumber].DraftSent = Today;

            x = DateTime.Parse(textBoxMeeting.Text);
            y = DateTime.Parse(textBoxDraftSent.Text);

            DraftDays = y - x;

            textBoxDraftDays.Text = DraftDays.ToString("dd");
            cases[RowNumber].DraftDays = int.Parse(textBoxDraftDays.Text);
            Console.WriteLine(cases[RowNumber].DraftDays);
        }

        //庁提出日入力
        private void buttonFiledDate_Click(object sender, EventArgs e)
        {
            DateTime Today;

            Today = monthCalendar.SelectionStart;
            textBoxFiledDate.Text = Today.ToShortDateString();
            cases[RowNumber].FiledDate = Today;
        }

        //スレッドリンク
        private void linkLabelCaseThread_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(cases[RowNumber].Thread);
        }

        //クライアント情報リンク、現時点では不使用
        private void linkLabelClientInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        //Wrapperリンク
        private void linkLabelElectricalWrapper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(cases[RowNumber].Wrapper);
        }

        //Roosterリンク
        private void linkLabelElectricalLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(cases[RowNumber].Rooster);
        }

        //メモ変更
        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            cases[RowNumber].Note=textBoxNote.Text;
        }
    }
}
