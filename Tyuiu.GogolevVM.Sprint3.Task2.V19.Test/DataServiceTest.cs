using Tyuiu.GogolevVM.Sprint3.Task2.V19.Lib;
namespace Tyuiu.GogolevVM.Sprint3.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int StartValue = 1;
            int StopValue = 10;

            double res = ds.GetSumSeries(StartValue, StopValue);

            double wait = -0.709;
            Assert.AreEqual(wait, res);
        }
    }
}
