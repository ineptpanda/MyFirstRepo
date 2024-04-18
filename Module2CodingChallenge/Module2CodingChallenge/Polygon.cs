﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Polygon
    {
        //attributes
        public int NumberOfSides { get; set; }

        //constructors
        public Polygon()
        {
            NumberOfSides = 0;
        }//end constructor

        public Polygon(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
    }//end class
}//end namespace
