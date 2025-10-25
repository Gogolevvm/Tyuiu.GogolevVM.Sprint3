using Tyuiu.GogolevVM.Sprint3.Task0.V1.Lib;
namespace Tyuiu.GogolevVM.Sprint3.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int Value = 1;

            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(Value, startValue, stopValue);

            int wait = 135;
            Assert.AreEqual(wait, res);

        }
    }
}
