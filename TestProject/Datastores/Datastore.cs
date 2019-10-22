using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTraining;

namespace TestProject.Datastores
{
    public static class Datastore
    {
        public static object[] Datas = new object[]
        {
            new bool[]
            {
                true,
                true,
                false,
                false,
                true,
                false,
                true,
                true,
                true,
                false,
                false,
                true,
            },
            new char[]
            {
                'D', 'A', 'D', 'B', 'D', 'D', 'D', 'D', 'D', 'D', 'C', 'D', 'A', 'B'
            },
            new int[] {
                3, 100, 23, 82, 4, 8, 12, 56, 31, 25, 67, 45, 99, 89
            },
            new List<string>
            {
                @"C:\Users\takahashi_m\Desktop\0\20190722.tmp",
                @"C:\20190811.tmp",
                @"N:\20190923.tmp",
                @"N:\Files\20190211.tmp",
                @"C:\554422\20190109.tmp",
                @"C:\作業用\Shared.tmp",
                @"N:\社員フォルダ\Shared\20190811.tmp",
                @"D:\資料\20190811.tmp",
                @"E:\20190811.tmp",
                @"N:\20180220.tmp",
                @"D:\資料\2019Shared.tmp",
                @"N:\社員フォルダ\Shared\Shared.tmp"
            },
            new int[]
            {
                4000,
                12000,
                2236,
                5548,
                9,
                12,
                255,
                299,
                0,
                3000,
                2333,
                5111,
                223,
                44,
                0,
                49922,
                14449,
                300
            },
            new string[]
            {
                "SELECT * FROM users WHERE id = 4000;",
                "SELECT * FROM users WHERE id = 12000;",
                "SELECT * FROM users WHERE id = 2236;",
                "SELECT * FROM users WHERE id = 5548;",
                "SELECT * FROM users WHERE id = 9;",
                "SELECT * FROM users WHERE id = 12;",
                "SELECT * FROM users WHERE id = 255;",
                "SELECT * FROM users WHERE id = 299;",
                "SELECT * FROM users;",
                "SELECT * FROM users WHERE id = 3000;",
                "SELECT * FROM users WHERE id = 2333;",
                "SELECT * FROM users WHERE id = 5111;",
                "SELECT * FROM users WHERE id = 223;",
                "SELECT * FROM users WHERE id = 44;",
                "SELECT * FROM users;",
                "SELECT * FROM users WHERE id = 49922;",
                "SELECT * FROM users WHERE id = 14449;",
                "SELECT * FROM users WHERE id = 300;"
            },
            new Dictionary<Answer5.AttackInfo, byte>
            {

            },
            new Answer3.UserInfo[]
            {
                new Answer3.UserInfo{ Age = 20, IsMale = true, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 29, IsMale = false, PastPurchaseCount = 2},
                new Answer3.UserInfo{ Age = 30, IsMale = false, PastPurchaseCount = 5},
            },
            new Answer4.Record[]
            {
                new Answer4.Record(){
                    DateTime = new DateTime(2019, 1, 21, 10, 21, 30),
                    Weather = Answer4.Weather.Sunny,
                    PaidPrice = 840
                },
            },
    };
    }
}
