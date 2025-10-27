using Tyuiu.GogolevVM.Sprint3.Task6.V10.Lib;
namespace Tyuiu.GogolevVM.Sprint3.Task6.V10.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 32;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 120;

            Assert.AreEqual(wait, res);
        }
    }
}
