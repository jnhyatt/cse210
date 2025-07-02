class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        float gradePercentage;
        while (!float.TryParse(Console.ReadLine(), out gradePercentage))
        {
            Console.Write("Invalid input. Please enter a valid grade percentage: ");
        }
        string letterGrade = gradePercentage switch
        {
            > 100f => "A+",
            >= 93f => "A",
            >= 90f => "A-",
            >= 87f => "B+",
            >= 83f => "B",
            >= 80f => "B-",
            >= 77f => "C+",
            >= 73f => "C",
            >= 70f => "C-",
            >= 67f => "D+",
            >= 63f => "D",
            >= 60f => "D-",
            _ => "F",
        };
        Console.WriteLine($"You got a {letterGrade}.");
        string message = gradePercentage switch
        {
            >= 90f => "Nice job, go work on a hobby!",
            >= 70f => "You passed!",
            _ => "Keep studying! You can do it!",
        };
        Console.WriteLine(message);
    }
}
