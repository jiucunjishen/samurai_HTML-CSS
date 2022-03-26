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
        //選択セルの行番号
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

        //アプリ起動時、DBからデータ読み込み
        private void FormMain_Load(object sender, EventArgs e)
        {
            //DBのuserテーブルを読み込んでusersインスタンスにマッピング
            users = SelectUsers();
            //担当者コンボボックスに追加
            comboBoxEngineer.Items.Add("全員");
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
                CaseList.DataTableCaseListRow row = caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());

                //リンク情報追加
                row.Case = @case;
            }

            //件数カウント＆表示
            int NumberOfCases;

            NumberOfCases = dataGridViewCaseList.Rows.Count;
            NumberOfCases--;

            textBoxNumberOfCases.Text = "　表示件数：　" + NumberOfCases.ToString();


            //期限1か月前のケースを赤色表示
            List<Case> urgentCases = cases.Where((@case) => DateTime.Now > @case.DueDate.AddMonths(-1)).ToList();

            foreach (Case @case in urgentCases)
            {           
                dataGridViewCaseList.Rows[cases.IndexOf(@case)].DefaultCellStyle.BackColor = Color.OrangeRed;
            }

        }

        //データグリッドビューセル選択時
        private void dataGridViewCaseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowNumber = e.RowIndex;

            if (RowNumber >= 0)
            {
                // 選択された行を取得
                CaseList.DataTableCaseListRow row = ((DataRowView)dataGridViewCaseList.Rows[RowNumber].DataBoundItem).Row as CaseList.DataTableCaseListRow;
                // リンク情報からCaseを取得
                Case clickedCase = row.Case;

                //受託日表示
                textBoxCaseReceived.Text = clickedCase.CaseReceived.ToShortDateString();
                //面談日表示
                textBoxMeeting.Text = clickedCase.Meeting.ToShortDateString();
                //補充資料受領日表示
                textBoxSupplementReceived.Text = clickedCase.SupplementReceived.ToShortDateString();
                //初稿期限日表示
                textBoxDraftDeadline.Text = clickedCase.DraftDeadline.ToShortDateString();
                //初稿送付日表示
                textBoxDraftSent.Text = clickedCase.DraftSent.ToShortDateString();
                //ドラフト日数表示
                textBoxDraftDays.Text = clickedCase.DraftDays.ToString();
                //庁提出日表示
                textBoxFiledDate.Text = clickedCase.FiledDate.ToShortDateString();
                //メモ表示
                textBoxNote.Text = clickedCase.Note.ToString();

            }
            else { }

        }

        //保存ボタン、DBのcaseテーブルに保存
        private void buttonStore_Click(object sender, EventArgs e)
        {
            //確認メッセージ表示
            DialogResult result = MessageBox.Show("データを上書き保存しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                foreach (Case @case in cases)
                {
                    InsertCase(@case);
                }
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
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
            DateTime Today = monthCalendar.SelectionStart;

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("受託日を"+ Today.ToShortDateString()+ "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxCaseReceived.Text = Today.ToShortDateString();
                cases[RowNumber].CaseReceived = Today;
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //面談日入力
        private void buttonMeeting_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("面談日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxMeeting.Text = Today.ToShortDateString();
                cases[RowNumber].Meeting = Today;
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //補充資料受領日入力
        private void buttonSupplementReceived_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("補充資料受領日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxSupplementReceived.Text = Today.ToShortDateString();
                cases[RowNumber].SupplementReceived = Today;
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //初稿期限日入力
        private void buttonDraftDeadline_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("初稿期限日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxDraftDeadline.Text = Today.ToShortDateString();
                cases[RowNumber].DraftDeadline = Today;
              
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //初稿送付日入力、ドラフト日数計算
        private void buttonDraftSent_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("初稿送付日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                DateTime x, y;
                TimeSpan DraftDays;

                textBoxDraftSent.Text = Today.ToShortDateString();
                cases[RowNumber].DraftSent = Today;

                x = DateTime.Parse(textBoxMeeting.Text);
                y = DateTime.Parse(textBoxDraftSent.Text);

                DraftDays = y - x;

                textBoxDraftDays.Text = DraftDays.ToString("dd");
                cases[RowNumber].DraftDays = int.Parse(textBoxDraftDays.Text);
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //庁提出日入力
        private void buttonFiledDate_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("庁提出日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxFiledDate.Text = Today.ToShortDateString();
                cases[RowNumber].FiledDate = Today;
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
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

        private User selectedUser;

        //担当者コンボボックス選択
        private void comboBoxEngineer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 全員
            if (comboBoxEngineer.SelectedIndex == 0)
            {
                // リストクリア
                caseList.DataTableCaseList.Clear();

                foreach (Case @case in cases)
                {
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
                }
            }
            // 個人
            else
            {
                // 選択されたユーザー
                selectedUser = users[comboBoxEngineer.SelectedIndex - 1];

                // リストクリア
                caseList.DataTableCaseList.Clear();

                // LINQ
                // casesの中からEngineerが選択されたユーザと同じものを抽出してデータグリッドビュー表示
                foreach (Case @case in cases.Where(@case => @case.Engineer == selectedUser.Name))
                {
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
                }
            }
        }

        //更新ボタン（チェックボックスの結果反映）
        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            // リストクリア
            caseList.DataTableCaseList.Clear();

/*          //期限管理中チェックボックスオン
            if (checkBoxDueOn.Checked == true)
            {
                foreach (Case @case in cases.Where(@case => @case.Flag == "管理中"))
                {
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
                }

            }
            else { }
*/


/*          //期限管理終了チェックボックスオン
            if (checkBoxDueOff.Checked == true)
            { 
                foreach (Case @case in cases.Where (@case => @case.Flag == "管理終了"))
                {
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
                }
            }
            else {}
 */

 /*         //国内出願チェックボックスオン
            if (checkBoxDomesticApplication.Checked == true)
            { 
                foreach (Case @case in cases.Where (@case => @case.Category == "出願" & @case.Region == "国内"))
                {
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
                }
            }
            else {}
 */

/*          //国内中間チェックボックスオン
            if (checkBoxDomesticOfficeAction.Checked == true)
            { 
                foreach (Case @case in cases.Where (@case => @case.Category == "中間" & @case.Region == "国内"))
                {
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
                }
            }   
            else {}
 */

 /*           //外国出願チェックボックスオン
            if (checkBoxForeignApplication.Checked == true)
            { 
                foreach (Case @case in cases.Where (@case => @case.Category == "出願" & @case.Region == "外国"))
                {
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
                }
            }   
            else {}
*/

            //外国中間チェックボックスオン
            if (checkBoxForeignOfficeAction.Checked == true)
            { 
                foreach (Case @case in cases.Where (@case => @case.Category == "中間" & @case.Region == "外国"))
                {
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.ToShortDateString());
                }
            }   
            else {}
        }

    }
}
