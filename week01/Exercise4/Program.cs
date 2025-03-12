using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int enter_number = -1;
        int sum = 0;
        int largest_number = 0;
        double average = 0;

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
        while(enter_number != 0)
        {
            Console.Write("Enter number: ");
            enter_number = int.Parse(Console.ReadLine());
            numbers.Add(enter_number);
        }

        numbers.RemoveAt(numbers.Count-1);
        Console.WriteLine(numbers.Count);
        foreach (int number in numbers)
        {
            sum = sum + number;
            Console.WriteLine(number);
            if(largest_number < number)
            {
                largest_number = number;
            }
        }
        average = (double)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest_number}");                
    }
}