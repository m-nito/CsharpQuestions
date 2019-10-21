using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpTraining
{
    public class Answer3
    {
        /// <summary>
        /// ユーザ情報のクラス
        /// </summary>
        public class UserInfo
        {
            /// <summary>
            /// このユーザの年齢
            /// </summary>
            public int Age;

            /// <summary>
            /// ユーザの性別（女性ならfalse）
            /// </summary>
            public bool IsMale;

            /// <summary>
            /// 過去一年間の購買数
            /// </summary>
            public int PastPurchaseCount;
        }

        /// <summary>
        /// 回答用メソッド
        /// </summary>
        /// <param name="userInfo">ユーザ情報</param>
        /// <returns>おすすめしたい商品のID</returns>
        public static int Recommend(UserInfo userInfo)
        {
            // 実装を行う
            return -1;
        }
    }
}
