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
        /// </summary>
        /// <param name="weather"></param>
        /// <param name="records"></param>
        /// <returns></returns>
        public static int GetCustomersByWeather(Weather weather, IEnumerable<Record> records)
        {
            return -1;
        }
        /// <summary>
        /// 回答用メソッド
        /// </summary>
        /// <param name="records"></param>
        /// <returns></returns>
        public static int GetBusiestHour(IEnumerable<Record> records)
        {
            return -1;
        }
        /// <summary>
        /// 回答用メソッド
        /// </summary>
        /// <param name="records"></param>
        /// <returns></returns>
        public static int GetMostProfitableDay(IEnumerable<Record> records)
        {
            return -1;
        }
    }
}
