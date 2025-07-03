using Resumes;

class Program
{
    static void Main()
    {
        new Resume
        {
            Name = "Josh Hyatt",
            Jobs = [
                new Job {
                    JobTitle = "Software Engineer",
                    Company = "Space Dynamics Lab",
                    StartYear = 2019,
                    EndYear = 2021,
                },
                new Job {
                    JobTitle = "Senior Software Engineer",
                    Company = "L3Harris",
                    StartYear = 2022,
                    EndYear = 2025,
                }
            ],
        }.Display();
    }
}
