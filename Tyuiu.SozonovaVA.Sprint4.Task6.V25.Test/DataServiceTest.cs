using Tyuiu.SozonovaVA.Sprint4.Task6.V25.Lib;
namespace Tyuiu.SozonovaVA.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var ok = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int res = ds.Calculate(ok);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
