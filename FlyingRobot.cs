using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTcsharp
{
    class FlyingRobot : Basebot
    {

        //public string flightpattern;
        //public string flightpath;
        //public string whatpartoftheatmopshere;


        public FlyingRobot(string Name, string Typeclass, int Baseattack, int Basedefense)
        {
            name = Name;
            typeclass = Typeclass;
            health = Health;
            strength = Strength;
            baseattack = Baseattack;
            basedefense = Basedefense;
        }
    }
}
