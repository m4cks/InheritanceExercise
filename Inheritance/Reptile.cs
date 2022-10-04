using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    internal class Reptile : Animal
    {
        public bool eatsBabies;
        public bool isScary;
        public int length;
        public bool hasLegs;
    }
}
