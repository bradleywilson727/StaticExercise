using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.FahrenheitToCelsius(100));

            Console.WriteLine(TempConverter.CelsiusToFahrenheit(45));
        }
    }
}
