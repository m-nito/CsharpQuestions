using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class Answer1
    {
        /// <summary>
        /// ヒント：文字列stringが””で区切られるのに対し、文字charは''で区切ることで示される点に注意してください
        /// ヒント：IEnumerableを返す必要があるため、主要な回答手段だけでも二種類存在します。
        /// 1. Listを作成してscoresの要素ごとに結果をAddしたものを返す
        ///   e.g. var list = new List<char>();
        ///        list.Add('D');
        ///        return list;
        /// 2. C# の yield return 記法を利用して返す
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        public IEnumerable<char> ScoresToGrades(IEnumerable<int> scores)
        {
            // 仮の戻り値を削除して回答を記載してください
            return null;
        }
    }
}
