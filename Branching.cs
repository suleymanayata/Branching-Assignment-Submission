
using System;

class ShippingEstimator13
{
    static void Main()
    {
        Console.WriteLine("You're now using the Package Express estimator. Let's go!");

        Console.Write("Weight (lbs): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal weight))
        {
            Console.WriteLine("Invalid weight entry.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy for Package Express.");
            return;
        }

        Console.Write("Width (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal width))
        {
            Console.WriteLine("Invalid width entry.");
            return;
        }

        Console.Write("Height (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal height))
        {
            Console.WriteLine("Invalid height entry.");
            return;
        }

        Console.Write("Length (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal length))
        {
            Console.WriteLine("Invalid length entry.");
            return;
        }

        decimal dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package dimensions exceed the limit.");
            return;
        }

        decimal quote = (width * height * length * weight) / 100;
        Console.WriteLine($">>> Estimated Shipping Quote: ${quote:F2}");
        Console.WriteLine("Thank you for using Package Express.");
    }
}
