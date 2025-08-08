using Mindfulness;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 4)
            {
                Console.Write("Invalid selection. Please choose a number between 1 and 4: ");
            }
            Activity activity = selection switch
            {
                1 => new BreathingActivity(),
                2 => new ReflectionActivity(),
                3 => new ListingActivity(),
                _ => null,
            };
            if (activity == null) break;
            activity.Start();
        }
    }
}