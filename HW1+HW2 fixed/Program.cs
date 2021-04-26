using System;

namespace HW1_HW2_fixed
{

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Square square1 = new Square();

            if (2 * circle1.radius <= square1.side)
            {
                Console.WriteLine("Круг умещается в квадрат");
            }
            else
            {
                Console.WriteLine("Круг не умещается в квадрат");
            }

            if (2 * (circle1.radius) >= square1.side * Math.Sqrt(2))

            {
                 Console.WriteLine("Квадрат умещается в круг");
            }
            else 
            {
                Console.WriteLine("Квадрат не умещается в круг");
            }
            Console.ReadKey();
        }
    }
}