using System;

namespace C_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // string NameInput1;
            // float Height1;
            // float Weight1;

            // Console.Write("Input your Name:");
            // NameInput1 = Console.ReadLine();
            // Console.Write("Input your Height");
            // Height1 = float.Parse(Console.ReadLine());
            // Console.Write("Input your Weight");
            // Weight1 = float.Parse(Console.ReadLine());

            // Console.WriteLine("Your Name is: " + NameInput1);
            // Console.WriteLine("Your Height is: " + Height1);
            // Console.WriteLine("Your Weight is: " + Weight1);

            float radius;
            string NameofShape;
            double pi = 3.14;
            double ans;

            Console.Write("Input your Shape");
            NameofShape = Console.ReadLine();
            float side;
            float length, width;
            float baseLength, height;
            
            
            if (NameofShape == "Circle")
            {
                Console.Write("Input the radius of the Circle: ");
                radius = float.Parse(Console.ReadLine());
                ans = pi * radius * radius;
                Console.WriteLine("The area of the Circle is: " + ans);
            }
            else if (NameofShape == "Square")
            {
                Console.Write("Input the side length of the Square: ");
                side = float.Parse(Console.ReadLine());
                ans = side * side;
                Console.WriteLine("The area of the Square is: " + ans);
            }

            else if (NameofShape == "Rectangle")
            {
                Console.Write("Input the length of the Rectangle: ");
                length = float.Parse(Console.ReadLine());
                Console.Write("Input the width of the Rectangle: ");
                width = float.Parse(Console.ReadLine());
                ans = length * width;
                Console.WriteLine("The area of the Rectangle is: " + ans);
            }
            else if (NameofShape == "Triangle")
            {
                Console.Write("Input the base length of the Triangle: ");
                baseLength = float.Parse(Console.ReadLine());
                Console.Write("Input the height of the Triangle: ");
                height = float.Parse(Console.ReadLine());
                ans = 0.5 * baseLength * height;
                Console.WriteLine("The area of the Triangle is: " + ans);
            }

            else
            {
                Console.WriteLine("Unknown shape");
            }




        }
    }
}
