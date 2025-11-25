using Tyuiu.SozonovaVA.Sprint4.Task5.V25.Lib;
namespace Tyuiu.SozonovaVA.Sprint4.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array ={{ -4, 3, -2, 2, 2, },

                            { 3, -1, 1, -1, 3, },

                            { 3, -2, 2, 2, -3, },

                            { -4, -3, -2, -1, -1, },

                            { 1, 2, 2, 3, 3, } };
            int wail = 32;
            int res = ds.Calculate(array);
            Assert.AreEqual(wail, res);
        }
    }
}
