using System;
using System.Collections.Generic;
using System.Text;

namespace HW1_HW2_fixed
{
    public class Square
    {

        public  double side;
        public static double area;
        public static string result;
        public static bool valid;
        public static int i;

        public Square()
        {
            i = 0;
            while (i < 3)
            {
                Console.Write("Введите значение стороны квадрата ->");
                bool valid = double.TryParse(Console.ReadLine(), out side);
                switch (valid)
                {
                    case true:
                        i = 4;
                        area = Math.Round((side * side), 2);
                        result = "Площадь квадрата равна " + area;
                        Console.WriteLine(Square.result);
                        break;
                    case false:
                        i++;
                        if (i < 3)
                        {
                            result = "Площадь квадрата не рассчитана. Введите валидное значение стороны.";
                            Console.WriteLine(Square.result);
                        }
                        else
                        {
                            Random rnd = new Random();
                            side = (rnd.NextDouble() * (5 - 0.5)) + 0.5;
                            area = Math.Round((side * side), 2);
                            result = "Площадь квадрата с рандомной стороной " + Math.Round(side, 2) + " равна " + area;
                            Console.WriteLine(Square.result);
                        }
                        break;
                }
            }
        }
    }
}