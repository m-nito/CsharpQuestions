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
        /// 1. ユーザが男性であるなら、127442 を返します。
        /// 2. ユーザが女性であり、30歳未満であるなら 284522 を返します。
        /// 3. ユーザが女性であり、30歳以上であるなら、292774 を返します。
        /// 4. ユーザが男性であり、過去一年間に一個でも商品を購入したことがあるなら、114596 を返します。
        /// 5. ユーザが女性であり、過去一年間の購買数が10以上であるなら、478256 を返します。
        /// 6. 上記の条件は、下に行くほど優先度が高くなります。
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
