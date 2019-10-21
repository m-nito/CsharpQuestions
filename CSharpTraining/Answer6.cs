using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpTraining
{
    /// <summary>
    /// ライト機能インターフェース
    /// </summary>
    public interface ILight
    {
        bool ChangeLight();
    }

    /// <summary>
    /// 回答用クラス
    /// </summary>
    public class Answer6 : ILight
    {
        public bool ChangeLight()
        {
            return false;
        }
    }
}
