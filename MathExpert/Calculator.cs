namespace MathExpert
{
    public class Calculator
    {
        public List<int> RanksList = new(); 

        public int Sum(int x, int y) =>  x + y;

        public double SumDouble(double x, double y) => x + y;

        public bool IsOdd(int num) => num % 2 != 0;

        public List<int> GetOddRanks(int start, int end)
        {
            RanksList.Clear();

            for (int i = start; i < end; i++)
            {
                if (i % 2 != 0) RanksList.Add(i); 
            }

            return RanksList;
        }
    }
}