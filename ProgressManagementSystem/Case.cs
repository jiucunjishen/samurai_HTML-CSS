using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressManagementSystem
{
    //Case（ケース）クラス
    public class Case
    {
        //ケース番号
        public string CaseNumber { get; set; }

        //クライアント整理番号
        public string ClientReference { get; set; }

        //クライアント名
        public string ClientName { get; set; }

        //窓口担当者
        public string Contact { get; set; }

        //担当者
        public string Engineer { get; set; }

        //クライアント知財担当者
        public string ClientContact { get; set; }

        //発明者
        public string Inventor { get; set; }

        //期限管理フラグ
        public string Flag { get; set; }

        //カテゴリ
        public string Category { get; set; }

        //地域
        public string Region { get; set; }

        //期限
        public DateTime DueDate { get; set; }

        //ケーススレッドリンク
        public string CaseThread { get; set; }

        //クライアントスレッドリンク
        public string ClientThread { get; set; }

        //Wrapperリンク
        public string Wrapper { get; set; }

        //Roosterリンク
        public string Rooster { get; set; }

        //受託日
        public DateTime CaseReceived { get; set; }

        //面談日
        public DateTime Meeting { get; set; }

        //補充資料受領日
        public DateTime SupplementReceived { get; set; }

        //ドラフト期限
        public DateTime DraftDeadline { get; set; }

        //ドラフト送付日
        public DateTime DraftSent { get; set; }

        //ドラフト日数
        public int DraftDays { get; set; }

        //庁提出日
        public DateTime FiledDate { get; set; }

        //メモ
        public string Note { get; set; }
    }
}
