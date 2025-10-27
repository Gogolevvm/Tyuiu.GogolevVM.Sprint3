using Tyuiu.GogolevVM.Sprint3.Task3.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint3.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "abcdef abcdef abcdef  abcdefabcdefabcdef ";
            char chr = 'a';

            int res = ds.GetCharCount(str, chr);

            int wait = 6;

            Assert.AreEqual(wait, res);


        }
    }
}
