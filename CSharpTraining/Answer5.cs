namespace CSharpTraining
{
    public class Answer5
    {
        /// <summary>
        /// 攻撃結果の列挙型(enum)
        /// tips: 列挙型は、内部的な実体は整数でしかありません。
        ///   人間が理解しやすいように、整数ではなく対応するキーを表示するものです。
        ///   （VisualStudioならばErrorなど定義の列挙子にマウスホバーすることで内部の数値を表示できます）
        /// </summary>
        public enum HitResult
        {
            Error,
            Miss,
            Hit,
            Critial,
        }
        /// <summary>
        /// 攻撃情報の構造体
        /// tips: 構造体structは、クラスclassと同様に複数の情報を保持できます。
        ///   しかしながらクラスのような内部状態を持つことはできず、使い捨てる前提の情報の集合体となります。
        ///   ※正確にはポインタをやりとりすることができない、という表現が正確ですが、詳細は省きます
        ///   利用者から見た場合は「高速なかわりに使い捨てないといけないクラス」と認識しておけば問題ないかと思います。
        /// </summary>
        public struct AttackInfo
        {
            public byte HitChance;
            public byte CriticalChance;
            public AttackInfo(byte h, byte c)
            {
                this.HitChance = h;
                this.CriticalChance = c;
            }
        }
        public HitResult GetHitResult(byte chance, AttackInfo atk)
        {
            return HitResult.Error;
        }
    }
}
