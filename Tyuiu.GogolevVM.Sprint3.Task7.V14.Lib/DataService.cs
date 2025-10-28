using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GogolevVM.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valleyArray;
            int len = (stopValue - startValue) + 1;
            valleyArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 * x - 1) / (Math.Sin(x) + 1) !=0)
                {
                    y = Math.Round(2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1)),2);
                }
                else
                {
                    y = 0;
                }
                valleyArray[count] = y;
                count++;
                
            }
            return valleyArray;
        }
    }
}
