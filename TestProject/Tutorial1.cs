using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpTraining;

namespace TestProject
{
    /// <summary>
    /// C# を利用した基本的な操作について扱います。
    /// </summary>
    public class Tutorial1
    {
        /// <summary>
        /// 変数の宣言と利用の例です。
        /// </summary>
        public void VariableDefinition()
        {
            bool b = true;
            byte bt = 255;
            int i = 10;
            string str = "text";
        }
        // 同様に、以下の4つのメソッドについて編集を行い、変数を宣言してreturnしてみましょう。

        /// <summary>
        /// falseを返してください。
        /// </summary>
        /// <returns></returns>
        public bool Boolean()
        {
            bool b = true;
            return b;
        }
        /// <summary>
        /// 10 を返してください。
        /// </summary>
        /// <returns></returns>
        public int Integer()
        {
            int i = 0;
            return i;
        }
        /// <summary>
        /// 255 を返してください。
        /// </summary>
        /// <returns></returns>
        public byte Byte()
        {
            byte b = 0;
            return b;
        }

        /// <summary>
        /// 文字列"text"を返してください。
        /// </summary>
        /// <returns></returns>
        public string String()
        {
            // このように、ローカル変数を宣言せず直に返すこともできます
            return "";
        }

        /// <summary>
        /// ここまでの処理が正しいかチェックできます。
        /// テストエクスプローラから、TestProject/TestProject/TUtorial1 を右クリックし、「実行」を選択します。
        /// すべての回答が正しいならば、緑色のパスアイコンが表示され、そうでないならば赤色の失敗アイコンが表示されます。
        /// 「デバッグ実行」を行うと、間違えた箇所でエラーが表示されます。
        /// </summary>
        [Test]
        public void Tutorial1Check()
        {
            Assert.IsFalse(Boolean());
            Assert.AreEqual(Integer(), 10);
            Assert.AreEqual(Byte(), 255);
            Assert.AreEqual(String(), "text");
        }


        public void MethodDefinition()
        {
            int i = 0;
            void editVariable(int val)
            {
                val = val + 1;
            }
            bool isNotZero(int val)
            {
                return val != 0;
            }
        }
        [Test]
        public void CastingType()
        {
            int val = 10;

            long ConvertToLong(int i)
            {
                return (long)i;
            }
            bool IsLong(object obj)
            {
                return obj is long;
            }
            Assert.IsTrue(IsLong(ConvertToLong(val)));

        }
        public void CreateArray()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int[] arr;
            arr = new int[3];
            for(int i = 0; i < 3; i++)
            {
                if (i == 0) arr[i] = a;
                if (i == 1) arr[i] = b;
                if (i == 2) arr[i] = c;
            }
        }
        public void InitializeArray()
        {
            long a = 1;
            long b = 2;
            long c = 3;
            int[] arr = new int[3] { (int)a, (int)b, (int)c };
        }

        public void CreateList()
        {
            var lis = new List<string>();
            var a = "1";
            var b = "2";
            var c = "3";
            lis.Add(a);
            lis.Add(b);
            lis.Add(c);
        }
        public void InitializeList()
        {
            var a = "1";
            var b = "2";
            var c = "3";
            var lis = new List<string>() { a, b, c };
        }
        public void RemoveList()
        {
            var a = "1";
            string b = null;
            var c = "2";
            var lis = new List<string>() { a, b, c };
            lis.Remove(null);
        }
    }
}
