using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpTraining
{
    public class Answer4
    {
        /// <summary>
        /// 販売記録
        /// </summary>
        public class Record
        {
            /// <summary>
            /// 販売日時
            /// </summary>
            public DateTime DateTime;
            /// <summary>
            /// 天気
            /// </summary>
            public Weather Weather;
            /// <summary>
            /// 販売価格
            /// </summary>
            public int PaidPrice;
        }
        /// <summary>
        /// 天気の列挙子
        /// </summary>
        public enum Weather
        {
            Error,
            Sunny,
            Cloudy,
            Rain,
        }
        /// <summary>
        /// 回答用メソッド
        /// この機能は、すべての期間の売り上げデータを精査して、天気ごとの一日あたり来客数(＝売上記録の数)の平均を返します。
        /// 第一引数に調べたい天気、第二引数に売り上げ記録が渡されます。
        /// </summary>
        /// <param name="weather"></param>
        /// <param name="records"></param>
        /// <returns></returns>
        public static int GetCustomerCountByWeather(Weather weather, IEnumerable<Record> records)
        {
            return -1;
        }
        /// <summary>
        /// 回答用メソッド
        /// この機能は、すべての期間について、最も来客数が多い時間帯を返します。
        /// </summary>
        /// <param name="records"></param>
        /// <returns></returns>
        public static int GetBusiestHour(IEnumerable<Record> records)
        {
            return -1;
        }
        /// <summary>
        /// 回答用メソッド
        /// この機能は、すべての期間について、最も売り上げの金額が多い日にちを返します。
        /// </summary>
        /// <param name="records"></param>
        /// <returns></returns>
        public static int GetMostProfitableDay(IEnumerable<Record> records)
        {
            return -1;
        }
    }
}
