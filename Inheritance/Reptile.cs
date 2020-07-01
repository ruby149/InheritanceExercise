using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            HasEyes = true;
        }
        public bool HasScales { get; set; }
        public string LandSea { get; set; } 
        public string BodyTemp { get; set; }
        public int Legs { get; set; } 
    }

}
