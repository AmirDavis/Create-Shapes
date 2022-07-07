using System;

namespace Assignment_4
{
    class Driver
    {
        static void Main(string[] args)
        {
            int userChoice = 9;
            bool rectangle = false;
            bool triangle = false;
            double s1, s2, s3, height;
            Rectangle r1 = new Rectangle();
            Triangle t1 = new Triangle();
            Menu menu = new Menu();

            while(userChoice != 0)
            {
                menu.printMenu(); //prints the menu that the user can choose from
                userChoice = Int32.Parse(Console.ReadLine()); //reads the user's decision

                switch (userChoice)
                {
                    case 0: //breaks out of the program
                        break;
                    case 1: //creates a rectangle with the user's specifications if the user has not created one already
                        if(rectangle == true)
                        {
                            Console.WriteLine("You already have a rectangle.");
                        }
                        else
                        {
                            Console.Write("Enter the length of the rectangle: ");
                                s1 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter the height of the rectangle: ");
                                s2 = Int32.Parse(Console.ReadLine());
                                r1 = new Rectangle(s1, s2);
                                rectangle = !rectangle;
                        }
                        break;
                    case 2: //creates a triangle with the user's specifications if the user has not created one already
                        if (triangle == true)
                        {
                            Console.WriteLine("You already have a triangle.");
                        }
                        else
                        {
                            Console.Write("Enter length 1 of the triangle: ");
                                s1 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter length 2 of the triangle: ");
                                s2 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter the base length of triangle: ");
                                s3 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter the height of the triangle: ");
                                height = Int32.Parse(Console.ReadLine());
                            t1 = new Triangle(s1, s2, s3);
                            triangle = !triangle;
                        }
                        break;
                    case 3:
                        if((rectangle == false) && (triangle == false))
                        {
                            Console.WriteLine("Default rectangle: ");
                                r1.ToString();
                            Console.WriteLine("Default triangle: ");
                                t1.ToString();
                        }
                        else if(rectangle == false)
                        {
                            Console.WriteLine("Default rectangle: ");
                            r1.ToString();
                            Console.WriteLine("User triangle: ");
                            t1.ToString();
                        }
                        else if(triangle == false)
                        {
                            Console.WriteLine("User rectangle: ");
                            r1.ToString();
                            Console.WriteLine("Default triangle: ");
                            t1.ToString();
                        }
                        else
                        {
                            Console.WriteLine("User rectangle: ");
                            r1.ToString();
                            Console.WriteLine("User triangle: ");
                            t1.ToString();
                        }
                        break;
                }
            }
        }
    }
}
