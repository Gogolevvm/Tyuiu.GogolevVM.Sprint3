using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GogolevVM.Sprint3.Task5.V0.Lib
{
    public class DataService : ISprint3Task5V0
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i,j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    sumSeries = sumSeries + ((1 / Math.Sin(j)) + x);
                }
            }
            return sumSeries;
        }
    }
}
