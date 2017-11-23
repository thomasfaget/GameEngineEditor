using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GameEngineEditor
{
    class PhysicsComponent : IComponent
    {
        // Data comming from XML
        public int masse = 1;
        public bool useGravity = false;
        public bool useAirFriction = true;
        public float airFrictionTweaker = .9f; // between 0 and 1       
    }
}
