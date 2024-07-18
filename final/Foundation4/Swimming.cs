namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int laps; 

        public Swimming(string date, int length, int laps)
            : base(date, length)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return (laps * 50) / 1000.0; // Distance in kilometers
        }
    }
}
