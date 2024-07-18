namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double speed; // Speed in kph

        public Cycling(string date, int length, double speed)
            : base(date, length)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return (speed / 60) * Length;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60 / speed;
        }
    }
}
