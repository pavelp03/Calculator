using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add"
        };
        public static string[] OptionsList = {
            "s - Substract"
        };
        public static string[] OptionsList = {
            "m - Multiply"
        };



        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public static void Substract(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }


    }
}
