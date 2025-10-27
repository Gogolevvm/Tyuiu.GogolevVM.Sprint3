﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GogolevVM.Sprint3.Task6.V10.Lib
{
    public class DataService : ISprint3Task6V10
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int d = 1;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 12)
                        {
                            sum += d;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
