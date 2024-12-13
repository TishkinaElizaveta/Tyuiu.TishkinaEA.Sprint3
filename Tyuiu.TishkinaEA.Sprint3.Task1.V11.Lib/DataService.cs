using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TishkinaEA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double product = 1; 
            int k = startValue;  

            while (k <= stopValue)
            {
                double term = Math.Pow(value, k) + 0.5; 
                product *= term; 
                k++; 
            }

            return Math.Round(product, 3); 
        }
    }
}
