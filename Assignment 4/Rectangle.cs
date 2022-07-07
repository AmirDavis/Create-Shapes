using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    class Rectangle : Shape
    {
        //default constructor
        public Rectangle() : base()
        {
        }

        //overloaded constructor
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        //calculates the area of the rectangle
        protected override double calculateArea()
        {
            area = side1 * side2;
            return area;
        }

        //calculates the perimeter of the rectangle
        protected override double calculatePerimeter()
        {
            perimeter = (side1 * 2) + (side2 * 2);
            return perimeter;
        }

        //returns side1
        protected override double GetSide1()
        {
            return side1;
        }

        //returns side2
        protected override double GetSide2()
        {
            return side2;
        }

        //Sets the user's value to side1
        protected override void SetSide1(int x)
        {
            side1 = x;
        }

        //sets the user's value to side2
        protected override void SetSide2(double y)
        {
            side2 = y;
        }
    }
}
