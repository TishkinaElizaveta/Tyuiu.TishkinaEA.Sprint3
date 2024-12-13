using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TishkinaEA.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisors = 0; 

            for (int number = startValue; number <= stopValue; number++)
            {
                for (int divisor = 6; divisor <= number; divisor++) 
                {
                    if (number % divisor == 0) 
                    {
                        totalDivisors++; 
                    }
                }
            }

            return totalDivisors; 
        }
    }
}
