using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    class Triangle : Shape
    {
        protected double side3; //base
        protected double height;

        //default constructor
        public Triangle() : base()
        {
            side3 = 5;
            height = 5;
        }

        //overloaded constructor
        public Triangle(double side1, double side2, double side3) : base(side1, side2)
        {
            this.side3 = side3;
        }

        //calculates and returns the area of the triangle
        protected override double calculateArea()
        {
            area = (height * side3) / 2;
            return area;
        }

        //calculates and returns the perimeter of the triangle
        protected override double calculatePerimeter()
        {
            perimeter = side1 + side2 + side3;
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

        //returns the base
        protected double GetSide3()
        {
            return side3;
        }

        protected double GetHeight()
        {
            height = (2 * calculateArea()) / side3;
            return height;
        }

        //sets side1 to the user's value
        protected override void SetSide1(int x)
        {
            side1 = x;
        }

        //sets side2 to the user's value
        protected override void SetSide2(double y)
        {
            side2 = y;
        }

        //Sets the base to user's value
        protected void SetSide3(double z)
        {
            side3 = z;
        }

        public override void ToString()
        {
            Console.WriteLine("Side1: " + side1 + " | Side2: " + side2 + " | Height: " + GetHeight() + " | Base: " + side3 + " | Area: " + calculateArea() + " | Perimeter: " + calculatePerimeter());
        }
    }
}
