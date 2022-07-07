using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    public abstract class Shape
    {
        protected double side1;
        protected double side2;
        protected double area;
        protected double perimeter;

        public Shape()
        {
            side1 = 5;
            side2 = 5;
        }

        public Shape(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        protected abstract double calculateArea();

        protected abstract double calculatePerimeter();
        
        protected abstract double GetSide1();

        protected abstract void SetSide1(int x);

        protected abstract double GetSide2();
        protected abstract void SetSide2(double y);

        virtual public void ToString()
        {
            Console.WriteLine("Width: " + side1 + " | Height: " + side2 + " | Area: " + calculateArea() + " | Perimeter: " + calculatePerimeter());
        }
    }
}
