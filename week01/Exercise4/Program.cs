using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.\n");
        int number = -1;
        int total = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberUser = Console.ReadLine();
            number = int.Parse(numberUser);

            if (number != 0)
            {
                total += number;
                numbers.Add(number);
            }
        }
        double average = numbers.Average();
        int largestNumber = numbers.Max();

        long smallestPositive = 9999999999999;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        Console.WriteLine($"\nThe sum is: {total}");
        Console.WriteLine($"The average is: {average:F3}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}\n");
    }
}