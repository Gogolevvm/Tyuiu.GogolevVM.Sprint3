using Tyuiu.GogolevVM.Sprint3.Task4.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint3.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 0.104;
            Assert.AreEqual(wait,res);
        }
    }
}
