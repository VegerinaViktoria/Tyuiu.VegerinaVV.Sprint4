using Tyuiu.VegerinaVV.Sprint4.Task1.V10.Lib;

namespace Tyuiu.VegerinaVV.Sprint4.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 4, 3, 5, 7, 5, 8, 6, 1, 1 };

            int res = ds.Calculate(numsArray);
            int wait = 525;

            Assert.AreEqual(wait, res);
        }
    }
}
