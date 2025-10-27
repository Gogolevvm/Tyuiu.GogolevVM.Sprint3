using Tyuiu.GogolevVM.Sprint3.Task1.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint3.Task1.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = -0.186;

            Assert.AreEqual(wait,res);
        }
    }
}
