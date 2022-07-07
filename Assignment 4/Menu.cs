using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    internal class Menu
    {
        public void printMenu()
        {
            Console.Write("--MENU-- " +
                    "\n0 - Exit " +
                    "\n1 - Add a Rectangle " +
                    "\n2 - Add a Triangle " +
                    "\n3 - Display All Shapes with Details " +
                    "\nPlease Choose an Option: ");
        }
    }
}
