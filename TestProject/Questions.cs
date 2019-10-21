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
    /// NUnitテストコードです。
    /// ここには問題が定義されており、CSharpTraining.AnswersN.csファイルへ正しく回答を行うと、
    /// VisualStudioテストエクスプローラでテストを実行した際グリーンが点灯するようになります。
    /// このファイルのコードは編集せず、回答のための編集はAnswerN.csファイルに行ってください。
    /// 
    /// ・問題の詳細はそれぞれのテストの概要に記載してあります。
    /// ・業務プログラミングにありがちなシナリオを元にしているので、
    /// 　職業プログラミングの片鱗を感じ取っていただければと思います。
    /// ・問題の難易度は出題順と関連しません。難しいと感じたら他の問題に手を付けることで、
    /// 　思わぬヒントを得ることもあるかもしれません。
    /// </summary>
    public class Questions
    {
        /// <summary>
        /// - Saved by the bell -
        /// 
        /// あなたは学習サイトの成績評価機能の実装を任されました。
        /// 
        /// 与えられる条件は以下の通りです。
        /// 1. この機能には、引数として生徒名などに紐づかない100点満点の試験得点のみがコレクションとして渡されます。
        /// 
        /// 以下の要件を満たすメソッドScoresToGrades()をAnswer1.csに実装してください。
        /// 1. 90点以上の得点には、文字’A’を返す
        /// 2. 80点以上の得点には、文字’B’を返す
        /// 3. 60点以上の得点には、文字’C’を返す
        /// 4. 上記に満たない得点には、文字’D’を返す
        /// 5. 以上の処理を、渡された試験得点すべてについて行い、コレクションとして返す
        /// </summary>
        [Test]
        public void Question1()
        {
            var datas = Datastore.Datas[2] as int[];
            var grades = new Answer1().ScoresToGrades(datas);
            var answers = Datastore.Datas[1] as char[];
            foreach (var ans in grades)
            {
                var expected = answers[Array.IndexOf(grades.ToArray(), ans)];
                Assert.AreEqual(expected, ans);
            }
        }

        /// <summary>
        /// - You shall not pass -
        /// 
        /// あなたは中小企業の情報システム担当者です。
        /// 現在、情報システム部が統括している社内アプリケーションについて、
        /// 一時保持ファイルを誤って社内NASであるN:ドライブに保存してしまうミスが多く問題になっています。
        /// そこで社員のケアレスミスを防ぐため、社内アプリケーションのファイル保存機能について
        /// N:ドライブ以下への保存を許可しないようなチェック機能を実装するよう依頼されました。
        /// 
        /// 以下の条件が与えられます。
        /// 1. 保存機能が呼び出されたとき、CheckDrive()メソッドが呼び出されます。
        /// 2. この機能は、保存を許可してよいときにtrue、そうでないときにfalseを返します。
        /// 3. この機能には、引数として保存先のファイルパスが文字列で渡されます。
        /// 
        /// 以下の要件を満たすCheckDrive()メソッドをAnswer2.csに実装してください。
        /// 1. 与えられたパスがNドライブを含むなら、falseを返す
        /// 2. 与えられたパスがNドライブであっても、パスに"Shared"を含むならtrueを返す。
        /// 3. ファイル名が"Shared"を含む場合ここまでの条件をパスしてしまうので、
        /// 上記の条件を満たしたとしても与えられたパスのファイル名が"Shared"を含む場合には、
        /// 禁止ファイル名とみなしてfalseを返します。
        /// </summary>
        [Test]
        public void Question2()
        {
            var datas = Datastore.Datas[3] as List<string>;
            var expectations = (bool[])Datastore.Datas[0];
            foreach (var d in datas)
            {
                var result = new Answer2().CheckDrive(d);
                var expected = expectations[datas.IndexOf(d)];
                Assert.AreEqual(expected, result);
            }
        }
        /// <summary>
        /// - We (don't) know who you are -
        /// 
        /// あなたはアパレル企業の新人社内エンジニアです。
        /// 最初の仕事として、ユーザへのおすすめ商品を表示する機能の実装を依頼されました。
        /// 類似したユーザに人気のある商品を紹介するようなきちんとしたレコメンドエンジンを作成する予算はないので、
        /// 簡単なチェックを行い、ユーザ属性に応じてこちらが売りたい商品を表示する機能としてほしい、とのことです。
        /// 非常に残念なオーダーな気がしましたが、郷に入っては郷に従えということで粛々と機能追加を行いましょう。
        /// 
        /// 以下の条件が与えられます。
        /// 1. 商品紹介機能Recommend()を作成します。
        /// 2. Recommend()には引数としてユーザ情報が与えられます。
        /// 3. ユーザ情報は、「年齢」、「性別」、「過去一年間の購買数」を持ちます。
        /// 4. Recommend()は、与えられたユーザ情報に応じて、紹介したい商品のIDを整数で返します。
        /// 
        /// Answer3.csにおいて以下の要件を満たしてください。
        /// 1. ユーザが男性であるなら、127442 を返します。
        /// 2. ユーザが女性であり、30歳未満であるなら 284522 を返します。
        /// 3. ユーザが女性であり、30歳以上であるなら、292774 を返します。
        /// 4. ユーザが男性であり、過去一年間に一個でも商品を購入したことがあるなら、114596 を返します。
        /// 5. ユーザが女性であり、過去一年間の購買数が10以上であるなら、478256 を返します。
        /// 6. 上記の条件は、下に行くほど優先度が高くなります。
        /// </summary>
        [Test]
        public void Question3()
        {
            
        }
        /// <summary>
        /// - Dancing in the rain -
        /// 
        /// あなたはオープンして半年のタピオカミルクティーチェーンから、
        /// 彼らが利用するソフトウェアへの機能追加を依頼されました。
        /// 売上の確認用ツールにおいて、以下を表示できるようにしたいとのことです。
        /// 
        /// 1. 天気ごとの来客数の平均値(雨の日なら来客数が少ないなどがわかるはずなので)
        /// 2. 来客数が多い時間帯(15時など)
        /// 3. 売上の多い日にち(給料日である毎月28日など)
        /// 
        /// 以下の条件が与えられます。
        /// 1. オープンから依頼時点までの売上記録が、コレクションとして与えられます。
        /// 2. 売上記録は、お客様の会計ごとに記録され、以下の情報を含みます。
        /// 2-A. 日付時刻
        /// 2-B. 天気
        /// 2-C. 売上金額
        /// 
        /// Answer4.csにおいて以下の要件を満たしてください。
        /// 1. GetCustomerCountByWeather()を実装します。
        /// 1-A. この機能は、すべての期間の売り上げデータを精査して、天気ごとの来客数(＝売上記録の数)の平均を返します。
        /// 2. GetBusiestHour()を実装します。
        /// 2-A. この機能は、すべての期間について、最も来客数が多い時間帯を返します。
        /// 3. GetMostProfitableDay()を実装します。
        /// 3-A. この機能は、すべての期間について、最も売り上げの金額が多い日にちを返します。
        /// </summary>
        [Test]
        public void Question4()
        {

        }
        /// <summary>
        /// - Test your luck -
        /// 
        /// 1. 第一引数には、ランダムな整数が0-100の区間で渡されます。
        /// 2. 第二引数には、キャラクターの攻撃情報が渡されます。
        /// 2-A. 攻撃情報は、命中率HitChanceを持ちます。
        /// 2-B. 攻撃情報は、クリティカル率CriticalChanceを持ちます。
        /// 
        /// 以下の要件を満たす必要があります。
        /// 1. 第一引数が命中率以下であるなら、攻撃が命中したことを示すHitを返します。
        /// 2. 第一引数がクリティカル率以下であるなら、致命傷を与えたことを示すCriticalを返します。
        /// 3. 第一引数が上記の条件に当てはまらないなら、攻撃が外れたことを示すMissを返します。
        /// 4. 上述の結果は、すべて列挙型であるHitResultとして返します。
        /// </summary>
        [Test]
        public void Question5()
        {
            Dictionary<Answer5.AttackInfo, byte> datas = new Dictionary<Answer5.AttackInfo, byte>();
            foreach (var kvp in datas)
            {
                var result = new Answer5().GetHitResult(kvp.Value, kvp.Key);
                var expected = Answer5.HitResult.Error;
                Assert.AreEqual(expected, result);
            }
        }

        /// <summary>
        /// - Shenzhen I.O. -
        /// あなたは警備ソリューションを販売する中小企業から依頼を受けました。
        /// 彼らは防犯のため監視カメラを設置しようとしていますが、
        /// 本物の監視カメラの一部にダミーのカメラを混入させることでコストカットを行いたいと考えています。
        /// 本物のカメラは通電状態であるなら5秒間隔でLEDが点灯するのですが、
        /// ダミーのカメラにはLED点灯機能だけを持つ簡易基盤を搭載しました。
        /// あなたは、その簡易基盤が本物と（見た目上）同様に振る舞うようなプログラムを作成する必要があります。
        /// 
        /// 以下の条件が与えられます。
        /// 1. ChangeLight()メソッドは、毎秒呼び出されます。
        /// 2. ChangeLight()メソッドがtrueを返すとライトが点灯し、falseを返すとライトが消灯します。
        /// 
        /// 以下の要件を満たす必要があります。
        /// 1. ILightインターフェースを搭載した、Answer6クラスを実装してください。
        /// 1-A. 「クラスを実装する」点に注意してください。ローカル変数のみならずクラスのフィールドも利用できます。
        /// 2. ライト機能が満たすべき要件は、以下の通りです。
        /// 2-A. 5秒に一回trueを返すことで、LEDライトを点灯させるChangeLight()メソッドを実装します。
        /// 2-B. 最初は消灯状態から開始し、5秒目のみライトが点灯し、6秒目には消灯させる必要があります。
        /// 2-C. 同様に9秒目で消灯していたライトが10秒目には点灯し、11秒目には消灯している...といった動作を60秒間隔で行います。
        /// </summary>
        [Test]
        public void Question6()
        {
            ILight ans = new Answer6();
            for (int i = 1; i < 999; i++)
            {
                var ret = ans.ChangeLight();
                if (i % 5 == 0) Assert.IsTrue(ret);
                else Assert.IsFalse(ret);
            }
        }

        /// <summary>
        /// あなたは現在開発中のWebアプリケーションのクエリ文作成処理を依頼されました。
        /// MySQLデータベースから実際のデータを抽出したり、画面に表示する機能は他の担当者が現在作成中です。
        /// クエリ文は文字列の形でハンドルされ、クエリ処理ライブラリが通信処理を行います。
        /// 今回はusersテーブルからidをサーチして該当するユーザの表示を行うクエリ文を作成する必要があります。
        /// ただし利用しているデータベースにはidの0が存在しません。0がサーチされた際にはすべてのユーザ情報を返します。
        /// 
        /// 以下の条件が与えられます。
        /// 1. GetQueryString()メソッドにはユーザIDを示す整数が渡されます。
        /// 以下の要件を満たすGetQueryString()メソッドを実装してください。
        /// 1. 与えられたユーザIDに応じてユーザを選択するクエリ文を文字列として生成し返します。
        /// 1-A. e.g. 与えられたユーザIDが10であるなら"SELECT * FROM users WHERE id = 10;"を返す。
        /// 1-B. e.g. 与えられたユーザIDが259であるなら"SELECT * FROM users WHERE id = 259;"を返す。
        /// 2. 与えられたユーザIDが0であるときのみ、すべてのユーザ情報を選択するクエリ文を文字列で返します。
        /// 2-A. e.g. ユーザID = 0 で"SELECT * FROM users;"を返す。
        /// </summary>
        [Test]
        public void Question7()
        {
            var ans = new Answer7();
            string[] expectations = new string[] { };
            for (int i = 0; i < 999; i++)
            {
                var actual = ans.GetQueryString(i);
                if (i == 0)
                {
                    Assert.AreEqual(expectations[0], actual);
                    continue;
                }
                Assert.AreEqual(expectations[1], actual);
            }
        }
    }
}
