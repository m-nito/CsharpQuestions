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
        /// ユーザ情報を受け取り、おすすめ商品を判定して返します。
        /// </summary>
        /// <param name="userInfo">ユーザ情報</param>
        /// <returns>おすすめしたい商品のID</returns>
        public int Recommend(UserInfo userInfo)
        {
            return -1;
        }
    }
}
