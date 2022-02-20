using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressManagementSystem
{
    //User（ユーザ）クラス
    public class User
    {
        //所員番号
        public int Id { get; set; }

        //氏名
        public string Name { get; set; }
        
        //グループ
        public string Group { get; set; }

        //メアド
        public string Email { get; set; }
    }
}
