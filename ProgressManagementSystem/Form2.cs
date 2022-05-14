using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Word操作用
using System.IO;

namespace ProgressManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Form2_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップされたファイル
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            listBox1.Items.AddRange(files); // リストボックスに表示

            //確認メッセージ表示
            DialogResult result = MessageBox.Show("最終データを準備しますか？",
                "質問",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                    string FolderName = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/" + "事務所整理番号" + "_" + "クライアント整理番号";
                    string FileName = "種類判別不可";

                    System.IO.DirectoryInfo di = System.IO.Directory.CreateDirectory(@FolderName);

                    Console.WriteLine(FolderName);

                    foreach (string tmp in files)
                    {

                    if (tmp.IndexOf("願書") >= 0)
                    {
                        FileName = FolderName + "/" + "事務所整理番号" + "_" + "クライアント整理番号" + "_" + "願書（最終版）" + ".docx";
                    }
                    else { }

                    if (tmp.IndexOf("明細書") >= 0)
                    {
                        FileName = FolderName + "/" + "事務所整理番号" + "_" + "クライアント整理番号" + "_" + "明細書（最終版）" + ".docx";
                    }
                    else { }

                    if (tmp.IndexOf("図面") >= 0)
                    {
                        FileName = FolderName + "/" + "事務所整理番号" + "_" + "クライアント整理番号" + "_" + "図面（最終版）" + ".docx";
                    }
                    else { }

//                    FileName = FolderName + "/" + tmp.Substring(tmp.Length - 12);

                        Console.WriteLine(FileName);
                        System.IO.File.Copy(tmp, FileName);
                    }
            }
            else if (result == DialogResult.No) { }
            else if (result == DialogResult.Cancel) { }

            MessageBox.Show("デスクトップにフォルダを作成しました。");

            this.Close();

        }
    }
}
