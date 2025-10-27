using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GogolevVM.Sprint3.Task2.V0.Lib
{
    public class DataService : ISprint3Task2V0
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do 
            {
                SumSeries = SumSeries + ((1/ Math.Sin(startValue)) + value);
                startValue++;
            
            } while (startValue <= stopValue);
            return Math.Round(SumSeries,3);
        }
    }
}
