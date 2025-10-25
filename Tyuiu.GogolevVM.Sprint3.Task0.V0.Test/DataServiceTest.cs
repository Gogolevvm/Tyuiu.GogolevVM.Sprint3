using Tyuiu.GogolevVM.Sprint3.Task0.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint3.Task0.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 5;
            int startvalue = 1;
            int stopvalue = 10;

            double res = ds.GetSumSeries(value, startvalue, stopvalue);

            double wait = 56.552;

            Assert.AreEqual(wait,res);
        }
    }
}
