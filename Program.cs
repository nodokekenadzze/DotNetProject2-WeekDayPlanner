using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, Choose a weekday: ");
        string weekday = Console.ReadLine().ToUpper();

        // Input for temperature in Celsius with validation
        int temperatureChoice = 0;
        bool isValidTemperature = false;
        while (!isValidTemperature)
        {
            Console.Write("Choose a temperature in Celsius: ");
            string tempInput = Console.ReadLine();
            isValidTemperature = int.TryParse(tempInput, out temperatureChoice);
            if (!isValidTemperature)
            {
                Console.WriteLine("Incorrect input format, please type a whole number.");
            }
        }

        // Input for rain condition
        Console.Write("Is it raining? (yes/no): ");
        bool isRain = Console.ReadLine().ToLower() == "yes"; // Fixed Boolean assignment

        // Input for free hours with validation
        int freeHours = 0;
        bool isValidFreeHours = false;
        while (!isValidFreeHours)
        {
            Console.Write("Tell me the amount of free hours: ");
            string freeHoursInput = Console.ReadLine();
            isValidFreeHours = int.TryParse(freeHoursInput, out freeHours);
            if (!isValidFreeHours)
            {
                Console.WriteLine("Incorrect input format, please type a whole number.");
            }
        }

        // Weekday validation
        if (weekday == "MONDAY" || weekday == "TUESDAY" || weekday == "WEDNESDAY" || weekday == "THURSDAY" || weekday == "FRIDAY")
        {
            Console.WriteLine("It is a working day.");
        }
        else if (weekday == "SATURDAY" || weekday == "SUNDAY")
        {
            Console.WriteLine("It is a weekend.");
        }
        else
        {
            Console.WriteLine("You must enter a valid weekday name.");
            return;
        }

        // Activity suggestion based on the day
        switch (weekday)
        {
            case "MONDAY":
                Console.WriteLine("Training session.");
                break;
            case "TUESDAY":
                Console.WriteLine("Reading session.");
                break;
            case "WEDNESDAY":
                Console.WriteLine("Yoga session.");
                break;
            case "THURSDAY":
                Console.WriteLine("Karate session.");
                break;
            case "FRIDAY":
                Console.WriteLine("Basketball session.");
                break;
            case "SATURDAY":
                Console.WriteLine("Tennis session.");
                break;
            case "SUNDAY":
                Console.WriteLine("Football session.");
                break;
            default:
                Console.WriteLine("You must enter a valid weekday name.");
                break;
        }

        // Temperature advice
        if (temperatureChoice > 30)
        {
            Console.WriteLine("It's too hot, stay home.");
        }
        else if (temperatureChoice <= 30 && temperatureChoice >= 20)
        {
            Console.WriteLine("It's a good temperature, let's walk.");
        }
        else if (temperatureChoice < 20 && temperatureChoice >= 10)
        {
            Console.WriteLine("It's a good temperature for exercise.");
        }
        else if (temperatureChoice < 10)
        {
            Console.WriteLine("It's cold, stay home.");
        }

        // Rain advice
        string isUmbrella = (isRain) ? "Take an umbrella" : "Don't need an umbrella";
        Console.WriteLine(isUmbrella);

        // Free hours activity suggestion
        if (freeHours >= 3)
        {
            Console.WriteLine("Let's watch a movie.");
        }
        else if (freeHours < 3)
        {
            Console.WriteLine("Watch a TV series.");
        }
    }
}
 