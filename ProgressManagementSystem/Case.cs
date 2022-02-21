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
        public string DueDate { get; set; }

        //スレッドリンク
        public string Thread { get; set; }

        //Wrapperリンク
        public string Wrapper { get; set; }

        //Roosterリンク
        public string Rooster { get; set; }

        //受託日
        public string CaseReceived { get; set; }

        //面談日
        public string Meeting { get; set; }

        //補充資料受領日
        public string SupplementReceived { get; set; }

        //ドラフト期限
        public string DraftDeadline { get; set; }

        //ドラフト送付日
        public string DraftSent { get; set; }
    }
}
