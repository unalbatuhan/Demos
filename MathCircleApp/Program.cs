using System;

namespace MathCircleApp

    //A program that finds the environment and area of the circle.
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.142857143;
            double space, environment, radius;
            Console.Write("Enter the radius = ");
            radius = Convert.ToInt32(Console.ReadLine());
            environment = 2 * PI * radius;
            space = PI * (Math.Pow(radius, 2));
            Console.WriteLine("Environent area cm = " + environment);
            Console.WriteLine("Circus Space Area cm = " + space);
            Console.ReadLine();
        }
    }
}
