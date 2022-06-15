using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double temperature)
        {
            return ((temperature - 32) * 5 / 9);
        }

        public static double CelsiusToFahrenheit(double temperature)
        {
            return ((temperature * 9 / 5) + 32);
        }
    }
}
