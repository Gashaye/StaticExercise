using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double celsius)
        {
            double fahrenheit;

            fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
        }

        public static double CelsiusToFahrenheit(double fahrenheit)
        {
            double celsius;

            celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
