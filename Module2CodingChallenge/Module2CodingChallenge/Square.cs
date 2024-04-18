using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Square : Polygon //using : is for shorthand inheritance. square is a child of polygon
    {
        //atributes
        //size of the square (four sides are all the same length)
        public float Size { get; set; }

        //constructor
        public Square(float size)
        {
            Size = size; //sets the value of the attribute to the value of the arguement passed into the constructor
            NumberOfSides = 4; //sets the value of the attribute
        }//end constructor
    }//end class
}//end namespace
