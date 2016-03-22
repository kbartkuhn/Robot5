using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTcsharp
{
    class RunningRobot : Basebot
    {

        



      


        public RunningRobot(string Name, string Typeclass, int Baseattack, int Basedefense)
        {
            name = Name;
            typeclass = Typeclass;
            health = 150;
            battery = 300;
            baseattack = Baseattack;
            basedefense = Basedefense;
            
        }




    }
}
