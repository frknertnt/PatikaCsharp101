using System;

public class Program
{
    // Define an enum named "DaysOfWeek"
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void Main()
    {
        // Declare a variable of the "DaysOfWeek" enum type
        DaysOfWeek day = DaysOfWeek.Friday;

        // Print the enum value
        Console.WriteLine("Today is: " + day);

        // Compare the enum value
        if (day == DaysOfWeek.Saturday || day == DaysOfWeek.Sunday)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }
    }
}
