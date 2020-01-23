using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WEATHER CALCULATOR ***");

            Console.WriteLine("Enter the temperature in Fahrenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int actualTemp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the relative humidity");
            int relativeHumidity = int.Parse(Console.ReadLine());

            decimal dewPoint = actualTemp - 9m / 25m * (100 - relativeHumidity);

            Console.WriteLine("The dew point is " + dewPoint);

            //Wind Chill

            Console.WriteLine("Enter the wind speed");

            int windSpeed = int.Parse(Console.ReadLine());

            double windChill = 35.74 + 0.6215 * actualTemp - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * actualTemp * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is " + windSpeed);
        }
    }
}
