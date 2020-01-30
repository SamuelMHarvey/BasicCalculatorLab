using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WEATHER CALCULATOR ***");

            // declare variables
            double actualTemp;
            double relativeHumidity;
            double windSpeed;

            // ask user for temp
            actualTemp = GetInput("Enter the temperature in Fahrenheit");


            if (actualTemp > 50)
            {
                // ask user for relative humidity
                relativeHumidity = GetInput("Enter the relative humidity");

                // calculate heat index
                double heatIndex = (0.5 * (actualTemp + 61 + (actualTemp - 68) * 1.2)) + (relativeHumidity * 0.094);
                Console.WriteLine("The heat index is " + Math.Round(heatIndex, 2) + " degrees Fahrenheit");
            }
            else
            {
                // ask for the wind speed
                windSpeed = GetInput("Enter the wind speed in miles per hour");

                // calculate the wind chill
                double windChill = 35.74 + 0.6215 * actualTemp - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * actualTemp * Math.Pow(windSpeed, 0.16);

                // print the wind chill
                Console.WriteLine("The wind chill is " + Math.Round(windChill, 2) + " degrees Fahrenheit");
            }
     
        }

        static double GetInput(string prompt)
        {
            string input;

            Console.WriteLine(prompt);
            input = Console.ReadLine();

            // is it a valid input? if so, put it in result
            bool validInput = double.TryParse(input, out double result);

            // if it's not, try again
            while (validInput == false)
            {

                Console.WriteLine(input + " is not a valid input");
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                validInput = double.TryParse(input, out result);

            }

            return result;
        }
     
    }
}
