using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TishkinaEA.Sprint3.Task4.V14.Lib
{
    public class DataService : ISprint3Task4V14
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0; 

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                double y = Math.Cos(x) / Math.Sin(x);

                sum += y;
            }

            return Math.Round(sum, 3);
        }
    }
}
