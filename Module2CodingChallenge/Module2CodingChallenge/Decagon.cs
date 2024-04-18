using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Decagon : Polygon
    {
        public float Size { get; set; }

        public Decagon(float size)
        {
            Size = size;
            NumberOfSides = 10;
        }//end con
    }//end class
}//end namespace
