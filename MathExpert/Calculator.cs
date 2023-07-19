namespace MathExpert
{
    public class Calculator
    {
        public int Sum(int x, int y) =>  x + y;

        public double SumDouble(double x, double y) => x + y;

        public bool IsOdd(int num) => num % 2 != 0;
    }
}