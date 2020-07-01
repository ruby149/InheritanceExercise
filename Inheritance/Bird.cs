using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir ="Air";
            HasEyes = true;
        }
        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public int Age { get; set; }
        public bool HasBeak { get; set; }
    }
}
