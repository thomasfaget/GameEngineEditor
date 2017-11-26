using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GameEngineEditor
{
    class InputComponent : IComponent
    {
        public bool componentEnable = false;
        public bool GetEnable() { return componentEnable; }
        public void SetEnable(bool value) { componentEnable = value; }

        // Data comming from XML
        public float inputTweaker = 1000f;

    }
}
