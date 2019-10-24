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
                [new Answer5.AttackInfo(10, 1)] = 30,
                [new Answer5.AttackInfo(80, 12)] = 82,
                [new Answer5.AttackInfo(95, 0)] = 44,
                [new Answer5.AttackInfo(71, 1)] = 56,
                [new Answer5.AttackInfo(20, 0)] = 81,
                [new Answer5.AttackInfo(95, 20)] = 12,
                [new Answer5.AttackInfo(50, 10)] = 72,
                [new Answer5.AttackInfo(60, 8)] = 10,
                [new Answer5.AttackInfo(82, 13)] = 12,
                [new Answer5.AttackInfo(30, 5)] = 20,
                [new Answer5.AttackInfo(50, 8)] = 19,
                [new Answer5.AttackInfo(82, 10)] = 5,
                [new Answer5.AttackInfo(10, 0)] = 21,
                [new Answer5.AttackInfo(50, 5)] = 5,
            },
            new Answer5.HitResult[]
            {
                 Answer5.HitResult.Miss,
                 Answer5.HitResult.Miss,
                 Answer5.HitResult.Hit,
                 Answer5.HitResult.Hit,
                 Answer5.HitResult.Miss,
                 Answer5.HitResult.Critial,
                 Answer5.HitResult.Miss,
                 Answer5.HitResult.Hit,
                 Answer5.HitResult.Critial,
                 Answer5.HitResult.Hit,
                 Answer5.HitResult.Hit,
                 Answer5.HitResult.Critial,
                 Answer5.HitResult.Miss,
                 Answer5.HitResult.Critial,
            },
            new Answer3.UserInfo[]
            {
                new Answer3.UserInfo{ Age = 20, IsMale = true, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 29, IsMale = false, PastPurchaseCount = 2},
                new Answer3.UserInfo{ Age = 30, IsMale = false, PastPurchaseCount = 5},
                new Answer3.UserInfo{ Age = 21, IsMale = false, PastPurchaseCount = 8},
                new Answer3.UserInfo{ Age = 51, IsMale = true, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 41, IsMale = true, PastPurchaseCount = 12},
                new Answer3.UserInfo{ Age = 32, IsMale = true, PastPurchaseCount = 15},
                new Answer3.UserInfo{ Age = 38, IsMale = true, PastPurchaseCount = 9},
                new Answer3.UserInfo{ Age = 44, IsMale = false, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 45, IsMale = true, PastPurchaseCount = 8},
                new Answer3.UserInfo{ Age = 61, IsMale = false, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 21, IsMale = true, PastPurchaseCount = 2},
                new Answer3.UserInfo{ Age = 22, IsMale = true, PastPurchaseCount = 1},
                new Answer3.UserInfo{ Age = 25, IsMale = false, PastPurchaseCount = 25},
                new Answer3.UserInfo{ Age = 34, IsMale = false, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 54, IsMale = true, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 31, IsMale = false, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 21, IsMale = true, PastPurchaseCount = 4},
                new Answer3.UserInfo{ Age = 25, IsMale = false, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 28, IsMale = true, PastPurchaseCount = 12},
                new Answer3.UserInfo{ Age = 39, IsMale = false, PastPurchaseCount = 0},
                new Answer3.UserInfo{ Age = 21, IsMale = true, PastPurchaseCount = 0},
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
