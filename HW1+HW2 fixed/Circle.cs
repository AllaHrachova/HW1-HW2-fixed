using System;
using System.Collections.Generic;
using System.Text;

namespace HW1_HW2_fixed
{
    public class Circle
    {

        public double radius;
        public static double area;
        public static string result;
        public static bool valid;
        const double Pi = 3.14;
        public static int i;
      
        public Circle()
        {
            i = 0;
            while (i < 3)
            {
                Console.Write("Введите значение радиуса круга ->");
                bool valid = double.TryParse(Console.ReadLine(), out radius);
                switch (valid)
                {
                    case true:
                        i = 4;
                        area = Math.Round((Pi * radius * radius), 2);
                        result = "Площадь круга равна " + area;
                        Console.WriteLine(Circle.result);
                        break;
                    case false:
                        i++;
                        if (i < 3)
                        {
                            result = "Площадь круга не рассчитана. Введите валидное значение радиуса.";
                            Console.WriteLine(Circle.result);
                        }
                        else
                        { 
                             Random rnd = new Random();
                             radius = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
                             area = Math.Round((Pi * radius * radius), 2);
                             result = "Площадь круга с рандомным радиусом " + Math.Round(radius, 2) + " равна " + area;
                             Console.WriteLine(Circle.result);
                        }
                        break;
                }
            }
        }
    }
}      