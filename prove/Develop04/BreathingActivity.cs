public class BreathingActivity : MindfulnessActivity
{
    protected override void PerformActivity()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int interval = Duration / 2;
        for (int i = 0; i < interval; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(5); // 5 seconds for breathing in
            Console.WriteLine("Breathe out...");
            ShowSpinner(5); // 5 seconds for breathing out
        }
    }
}
