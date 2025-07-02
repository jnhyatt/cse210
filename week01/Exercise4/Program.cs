class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        var numbers = PromptForNumbers().ToList();
        Console.WriteLine($"The sum is {numbers.Sum()}.");
        Console.WriteLine($"The average is {numbers.Average()}.");
        Console.WriteLine($"The largest number is {numbers.Max()}.");
        Console.WriteLine($"The smallest positive is {numbers.Where(n => n > 0).Min()}.");
        Console.WriteLine($"The sorted list is:\n{string.Join("\n", numbers.OrderBy(n => n))}.");
    }

    static IEnumerable<int> PromptForNumbers()
    {
        while (true)
        {
            Console.Write("Enter a number (or 0 to finish): ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            if (number == 0) break;
            yield return number;
        }
    }
}