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
//ワード操作用
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
//selenium(Chrome)操作用
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


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

            //DBのcaseテーブルを読み込んでcasesインスタンスにマッピング
            cases = SelectCases();
            //duedate nullをMax設定
            foreach (Case @case in cases)
            {
                if (@case.DueDate == null)
                {
                    @case.DueDate = DateTime.MaxValue;
                }
                else { }

            }

            // フィルターを通って実際に表示するCaseを格納（ここからチェックの入っていないものを除外していく）
            List<Case> tmpcases = new List<Case>(cases);

            //期限管理中チェックボックスオフ
            if (checkBoxDueOn.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Flag != "管理中").ToList();
            }

            //期限管理終了チェックボックスオフ
            if (checkBoxDueOff.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Flag != "管理終了").ToList();
            }

            //国内出願チェックボックスオフ
            if (checkBoxDomesticApplication.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "国内出願").ToList();
            }

            //国内中間チェックボックスオフ
            if (checkBoxDomesticOfficeAction.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "国内中間").ToList();
            }

            //外国出願チェックボックスオフ
            if (checkBoxForeignApplication.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "外国出願").ToList();
            }

            //外国中間チェックボックスオフ
            if (checkBoxForeignOfficeAction.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "外国中間").ToList();
            }

            //その他チェックボックスオフ
            if (checkBoxOthers.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "その他").ToList();
            }

            // DataTableCaseListRow化
            foreach (Case @case in tmpcases)
            {
                caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.Value.ToShortDateString());
            }

            //件数カウント＆表示
            int NumberOfCases;

            NumberOfCases = dataGridViewCaseList.Rows.Count;
            NumberOfCases--;

            textBoxNumberOfCases.Text = "　表示件数：　" + NumberOfCases.ToString();


            //期限管理中かつ期限14日前のケースを赤字表示
            List<Case> urgentCases = tmpcases.Where(@case => @case.Flag == "管理中" && DateTime.Now > @case.DueDate.Value.AddDays(-14)).ToList();

            foreach (Case @case in urgentCases)
            {
                dataGridViewCaseList.Rows[tmpcases.IndexOf(@case)].DefaultCellStyle.ForeColor = Color.OrangeRed;
            }
        }

        //データグリッドビューセル選択時
        private void dataGridViewCaseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowNumber = e.RowIndex;
            int NumberOfCases = dataGridViewCaseList.Rows.Count;
            NumberOfCases--;

            if (RowNumber >= 0 && RowNumber < NumberOfCases)
            {

                //選択されたケース番号のケースにする
                Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();

                //受託日表示
                textBoxCaseReceived.Text = clickedCase.CaseReceived == null ? "" : clickedCase.CaseReceived.Value.ToShortDateString();
                //面談日表示
                textBoxMeeting.Text = clickedCase.Meeting == null ? "" : clickedCase.Meeting.Value.ToShortDateString();
                //補充資料受領日表示
                textBoxSupplementReceived.Text = clickedCase.SupplementReceived == null ? "" : clickedCase.SupplementReceived.Value.ToShortDateString();
                //初稿期限日表示
                textBoxDraftDeadline.Text = clickedCase.DraftDeadline == null ? "" : clickedCase.DraftDeadline.Value.ToShortDateString();
                //初稿送付日表示
                textBoxDraftSent.Text = clickedCase.DraftSent == null ? "" : clickedCase.DraftSent.Value.ToShortDateString();
                //ドラフト日数表示
                textBoxDraftDays.Text = clickedCase.DraftDays == null ? "" : clickedCase.DraftDays.Value.ToString();
                //庁提出日表示
                textBoxFiledDate.Text = clickedCase.FiledDate == null ? "" : clickedCase.FiledDate.Value.ToShortDateString();
                //メモ表示
                textBoxNote.Text = clickedCase.Note == null ? "" : clickedCase.Note.ToString();

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
//            MySqlConnection con = new MySqlConnection("Database=progressmanagementsystem;Data Source=192.168.1.5;User Id=test;");
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
                    " @CaseThread, @ClientThread, @Wrapper, @Rooster, @CaseReceived, @Meeting, @SupplementReceived, @DraftDeadline," +
                    " @DraftSent, @DraftDays, @FiledDate, @Note)" +
                    " on duplicate key update clientreference=@ClientReference, clientname=@ClientName, contact=@Contact," +
                    " engineer=@Engineer, clientcontact=@ClientContact, inventor=@Inventor, flag=@Flag, category=@Category," +
                    " region=@Region, duedate=@DueDate, casethread=@CaseThread, clientthread=@ClientThread, wrapper=@Wrapper, rooster=@Rooster, casereceived=@CaseReceived," +
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

            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("受託日を"+ Today.ToShortDateString()+ "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxCaseReceived.Text = Today.ToShortDateString();
                clickedCase.CaseReceived = Today;
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //面談日入力
        private void buttonMeeting_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("面談日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxMeeting.Text = Today.ToShortDateString();
                clickedCase.Meeting = Today;
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //補充資料受領日入力
        private void buttonSupplementReceived_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("補充資料受領日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxSupplementReceived.Text = Today.ToShortDateString();
                clickedCase.SupplementReceived = Today;
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //初稿期限日入力
        private void buttonDraftDeadline_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("初稿期限日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxDraftDeadline.Text = Today.ToShortDateString();
                clickedCase.DraftDeadline = Today;
              
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //初稿送付日入力、ドラフト日数計算
        private void buttonDraftSent_Click(object sender, EventArgs e)
        {
            DateTime SelectedDay = monthCalendar.SelectionStart;

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("初稿送付日を" + SelectedDay.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                DateTime x;
                TimeSpan z;

                textBoxDraftSent.Text = SelectedDay.ToShortDateString();
                //選択されたケース番号のケースにする
                Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();
                clickedCase.DraftSent = SelectedDay;

                x = clickedCase.CaseReceived.Value;
                if (clickedCase.Meeting != null)
                {
                    x = clickedCase.Meeting.Value;
                }
                else { }

                if (clickedCase.SupplementReceived != null)
                {
                    x = clickedCase.SupplementReceived.Value;
                }
                else { }
                z = clickedCase.DraftSent.Value - x;

                textBoxDraftDays.Text =z.ToString("dd");
                clickedCase.DraftDays = int.Parse(textBoxDraftDays.Text);
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //庁提出日入力
        private void buttonFiledDate_Click(object sender, EventArgs e)
        {
            DateTime Today = monthCalendar.SelectionStart;

            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("庁提出日を" + Today.ToShortDateString() + "に設定／変更しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                textBoxFiledDate.Text = Today.ToShortDateString();
                clickedCase.FiledDate = Today;
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }
        }

        //スレッドリンク
        private void linkLabelCaseThread_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();
            System.Diagnostics.Process.Start(clickedCase.CaseThread);
        }

        //クライアント情報リンク、現時点では不使用
        private void linkLabelClientInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        //Wrapperリンク
        private void linkLabelElectricalWrapper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();
            System.Diagnostics.Process.Start(clickedCase.Wrapper);
        }

        //Roosterリンク
        private void linkLabelElectricalLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();
            System.Diagnostics.Process.Start(clickedCase.Rooster);
        }

        //メモ変更
        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            //選択されたケース番号のケースにする
            Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();
            clickedCase.Note=textBoxNote.Text;
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
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.Value.ToShortDateString());
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
                    caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.Value.ToShortDateString());
                }
            }
        }

        //更新ボタン（チェックボックスの結果反映）
        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            // リストクリア
            caseList.DataTableCaseList.Clear();

            // フィルターを通って実際に表示するCaseを格納（ここからチェックの入っていないものを除外していく）
            List<Case> tmpcases = new List<Case>(cases);

            //期限管理中チェックボックスオフ
            if(checkBoxDueOn.Checked ==false)
            {
                tmpcases = tmpcases.Where(@case => @case.Flag != "管理中").ToList();            
            }

            //期限管理終了チェックボックスオフ
            if (checkBoxDueOff.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Flag != "管理終了").ToList();
            }

            //国内出願チェックボックスオフ
            if (checkBoxDomesticApplication.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "国内出願").ToList();
            }

            //国内中間チェックボックスオフ
            if (checkBoxDomesticOfficeAction.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "国内中間").ToList();
            }

            //外国出願チェックボックスオフ
            if (checkBoxForeignApplication.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "外国出願").ToList();
            }

            //外国中間チェックボックスオフ
            if (checkBoxForeignOfficeAction.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "外国中間").ToList();
            }

            //その他チェックボックスオフ
            if (checkBoxOthers.Checked == false)
            {
                tmpcases = tmpcases.Where(@case => @case.Category != "その他").ToList();
            }

            // DataTableCaseListRow化
            foreach (Case @case in tmpcases)
            {
                caseList.DataTableCaseList.AddDataTableCaseListRow(@case.Contact, @case.Engineer, @case.CaseNumber, @case.ClientName, @case.ClientReference, @case.DueDate.Value.ToShortDateString());
            }

            //件数カウント＆表示
            int NumberOfCases;

            NumberOfCases = dataGridViewCaseList.Rows.Count;
            NumberOfCases--;

            textBoxNumberOfCases.Text = "　表示件数：　" + NumberOfCases.ToString();


            //期限管理中かつ期限14日前のケースを赤字表示
            List<Case> urgentCases = tmpcases.Where(@case => @case.Flag == "管理中" && DateTime.Now > @case.DueDate.Value.AddDays(-14)).ToList();

            foreach (Case @case in urgentCases)
            {
                dataGridViewCaseList.Rows[tmpcases.IndexOf(@case)].DefaultCellStyle.ForeColor = Color.OrangeRed;
            }


        }

        //再起動ボタン
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void WordReplace(Word.Application word, string text1, string text2)
        {
            object oFindText = text1;
            object oReplaceText = text2;
            //            object oFindText = "日付";
            //            object oReplaceText = DateTime.Now.ToLongDateString();
            object oTru = true;
            object oFal = false;
            object oFindStop = Microsoft.Office.Interop.Word.WdFindWrap.wdFindStop;
            object oMis = Missing.Value;
            object oNoReplace = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            bool foundPrefix = word.Selection.Find.Execute(
                ref oFindText,// FindText: 特殊文字あり注意。
                              //   You can search for special characters by specifying appropriate character codes.
                              //   For example, "^p" corresponds to a paragraph mark and "^t" corresponds to a tab character. 
                ref oTru,// MatchCase: True to specify that the find text be case-sensitive.
                ref oFal,// MatchWholeWord: 単語単位での検索
                ref oFal,// MatchWildcards
                false,// MatchSoundsLike: あいまい検索
                ref oFal,// MatchAllWordForms:
                         //   True to have the find operation locate all forms of the find text (for example, "sit" locates "sitting" and "sat").
                ref oTru,// Forward: Trueで前方検索
                ref oFindStop,// Wrap: 検索しきった後に、最初から検索しなおすかどうかを指定する
                ref oMis,// Format: よくわからない
                ref oReplaceText,// ReplaceWith
                ref oNoReplace,// Replace: ここではReplaceしない指定とする (oMisでもよいのかも)
                ref oMis,// MatchKashida: アラビア語関連の機能らしい。
                ref oMis,// MatchDiacritics: 右から左に読む言語関連の機能らしい。
                ref oMis,// MatchAlefHamza: アラビア語関連の機能らしい。
                ref oMis // MatchControl: 右から左に読む言語関連の機能らしい。
            );
            Console.WriteLine(foundPrefix.ToString());
        }

        //コンテキストメニュー、コメント作成、コメント（一般）作成
        private void コメント一般作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Word アプリケーションオブジェクトを作成
                Word.Application word = new Word.Application();
                // Word の GUI を起動しないようにする
                word.Visible = false;

                // テンプレ（ひな形）を開く
                Document document = word.Documents.Open("C:Users//yoshi//OneDrive//デスクトップ//コメント（一般）ひな形.docx");

                //選択されたケース番号のケースにする
                Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();

                WordReplace(word, "日付", DateTime.Now.ToLongDateString());
                WordReplace(word, "出願人", clickedCase.ClientName);
                WordReplace(word, "知財担当者 様", clickedCase.ClientContact + " 様");
                WordReplace(word, "貴社整理番号", "貴社整理番号：" + clickedCase.ClientReference);
                WordReplace(word, "弊所整理番号", "弊所整理番号：" + clickedCase.CaseNumber);
                WordReplace(word, "応答期限", "応答期限：" + clickedCase.DueDate.Value.ToLongDateString());

                // 名前を付けて保存
                object filename = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/" + clickedCase.ClientReference + "_弊所コメント.docx";
                document.SaveAs2(ref filename);

                // 文書を閉じる
                document.Close();
                document = null;
                word.Quit();
                word = null;

                Console.WriteLine("Document created successfully !");
                MessageBox.Show("作成完了。ファイルをデスクトップに置きます。");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //コンテキストメニュー、コメント作成、コメント（ソニー）作成
        private void コメントソニー作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Word アプリケーションオブジェクトを作成
                Word.Application word = new Word.Application();
                // Word の GUI を起動しないようにする
                word.Visible = false;

                // テンプレ（ひな形）を開く
                Document document = word.Documents.Open("C:Users//yoshi//OneDrive//デスクトップ//コメント（ソニー）ひな形.docx");

                //選択されたケース番号のケースにする
                Case clickedCase = cases.Where(@case => @case.CaseNumber == dataGridViewCaseList.Rows[RowNumber].Cells[2].Value.ToString()).First();

                WordReplace(word, "整理番号：", "貴社整理番号：" + clickedCase.ClientReference);

                // 名前を付けて保存
                object filename = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/" + clickedCase.ClientReference + "_弊所コメント.docx";
                document.SaveAs2(ref filename);

                // 文書を閉じる
                document.Close();
                document = null;
                word.Quit();
                word = null;

                Console.WriteLine("Document created successfully !");
                MessageBox.Show("作成完了。ファイルをデスクトップに置きます。");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //コンテキストメニュー、データ準備、最終データ準備
        private void 最終データ準備ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog(this);
            f.Dispose();
        }

        //seleniumテストボタン
        private void buttonWebAccess_Click(object sender, EventArgs e)
        {
            // Webドライバーのインスタンス化
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

            // URLに移動します。
//            driver.Navigate().GoToUrl(@"https://www.google.co.jp/");
            driver.Navigate().GoToUrl(@"https://patents.google.com/");

            // 検索をするInputタグを取得
            IWebElement textbox = driver.FindElement(By.Name("q"));

            // テキストを打ち込む
//            textbox.SendKeys("はなちるのマイノート");
            textbox.SendKeys("JP2018026624A");

            // 送信(検索)
            textbox.Submit();

            // なにかコンソールに文字を入力したらクロームを閉じる
//            Console.ReadKey();
//            Console.Read();
            driver.Quit();

        }
    }
}
