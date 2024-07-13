public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void PerformActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have 5 seconds to start thinking...");
        ShowSpinner(5);
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Keep listing items:");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                count++;
            }
        }
        Console.WriteLine($"You have listed {count} items.");
    }
}
