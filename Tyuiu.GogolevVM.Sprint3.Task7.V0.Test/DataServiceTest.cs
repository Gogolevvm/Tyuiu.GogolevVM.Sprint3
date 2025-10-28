using Tyuiu.GogolevVM.Sprint3.Task7.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint3.Task7.V0.Test
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

            int len = stopValue - startValue + 1;

            double[] valeyWaitArray;
            valeyWaitArray = new double[len];

            valeyWaitArray[0] = 0.96;
            valeyWaitArray[1] = 0.76;
            valeyWaitArray[2] = -0.14;
            valeyWaitArray[3] = -0.91;
            valeyWaitArray[4] = -0.84;
            valeyWaitArray[5] = 0.00;
            valeyWaitArray[6] = 0.84;
            valeyWaitArray[7] = 0.91;
            valeyWaitArray[8] = 0.14;
            valeyWaitArray[9] = -0.76;
            valeyWaitArray[10] = -0.96;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valeyWaitArray,res);

        }
    }
}
