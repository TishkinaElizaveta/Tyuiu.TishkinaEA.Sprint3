using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TishkinaEA.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1; 
            int k = startValue; 

            double constantTerm = 1 / Math.Pow((Math.Cos(5) + 1), 2);

            do
            {
                product *= constantTerm; 
                k++; 
            }
            while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }
}
