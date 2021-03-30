using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"10 Fahrenheit = {TempConverter.FahrenheitToCelsius(10)} celcius");

           Console.WriteLine($"50 Celcius = {TempConverter.CelsiusToFahrenheit(50)} Fahrenheit");
        }
    }
}
