using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GogolevVM.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V1
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double Sumseries = 0;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                Sumseries = Sumseries + (value * value * i + 1);
            }
            return Sumseries;
        }
    }
}
