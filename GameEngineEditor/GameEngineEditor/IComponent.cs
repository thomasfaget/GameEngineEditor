using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineEditor
{
    interface IComponent
    {
        bool GetEnable();
        void SetEnable(bool value);
    }
}
