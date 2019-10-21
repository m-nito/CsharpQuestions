using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
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
            new int[] { 3, 100, 23, 82, 4, 8, 12, 56, 31, 25, 67, 45, 99, 89 },
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
    };
    }
}
