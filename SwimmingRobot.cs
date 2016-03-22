using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTcsharp
{
    class SwimmingRobot : Basebot
    {
     

        public SwimmingRobot(string Name, string Typeclass, int Baseattack, int Basedefense)
        {
            name = Name;
            typeclass = Typeclass;
            health = 200;
            battery = 100;
            baseattack = Baseattack;
            basedefense = Basedefense;
          
        }

        public int getattackedwithflamethrower()
        {
            health -= 30;
            return health;
        }
        public int attackwithyourmother()
        {
            health += 25;
            return health;
        }
    }
}
