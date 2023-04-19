namespace _19AprilExercise.Models
{
    public class Calculate
    {
        public double Number { get; set; }
        public double Result { get; set; }
        public Calculate(double number, double result)
        {
            Number = number;
            Result = result;
        }
        public Calculate()
        {

        }
    }
}
