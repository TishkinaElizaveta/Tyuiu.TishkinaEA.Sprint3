using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TishkinaEA.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int range = stopValue - startValue + 1; 
            double[] results = new double[range]; 

            for (int i = 0; i < range; i++)
            {
                int x = startValue + i;

                double denominator = 4 * x - 0.5;
                if (Math.Abs(denominator) < 1e-10) 
                {
                    results[i] = 0;
                }
                else
                {
                    double fx = (3 * Math.Cos(x) / denominator) + Math.Sin(x) - 5 * x - 2;
                    results[i] = Math.Round(fx, 2);
                }
            }

            return results; 
        }
    }
}
