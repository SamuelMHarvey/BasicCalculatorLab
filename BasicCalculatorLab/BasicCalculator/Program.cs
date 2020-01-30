using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WEATHER CALCULATOR ***");

            // declare variables
            string input;
            int actualTemp;
            int relativeHumidity;
            int windSpeed;
            int dewPoint;

            // ask user for temp
            actualTemp = GetIntegerInput("Enter the temperature in Fahrenheit");

            // bool isInt = int.TryParse(input, out actualTemp);

            // ask user for relative humidity
            relativeHumidity = GetIntegerInput("Enter the relative humidity");

            // calculate the dew point
            dewPoint = actualTemp - 9 * (100 - relativeHumidity) / 25;

            // print the dew point
            Console.WriteLine("The dew point is " + dewPoint + " degrees Fahrenheit");
            
            // ask for the wind speed
            Console.WriteLine("Enter the wind speed in miles per hour");
            input = Console.ReadLine();
            windSpeed = int.Parse(input);

            // calculate for the wind chill
            double windChill = 35.74 + 0.6215 * actualTemp - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * actualTemp * Math.Pow(windSpeed, 0.16);

            // print the wind chill
            Console.WriteLine("The wind chill is " + Math.Round(windChill, 2) + " degrees Fahrenheit");
        }

        // creating a method
        static int GetIntegerInput(string prompt)
        {
            string input;
            int result;
            Console.WriteLine(prompt);

            input = Console.ReadLine();
            result = int.Parse(input);

            return result;
        }
     
    }
}
