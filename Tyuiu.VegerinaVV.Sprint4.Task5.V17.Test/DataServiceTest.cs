using Tyuiu.VegerinaVV.Sprint4.Task5.V17.Lib;

namespace Tyuiu.VegerinaVV.Sprint4.Task5.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -9, 4, 2, -6, -1 },
                                          { 1, -8, -7, 3, -2 },
                                          { -5, -4, 1, -3, 2 },
                                          { 2, -5, 1, -6, -4 },
                                          { 3, -5, -3, 1, -2 } };
            int res = ds.Calculate(mas2);
            int wait = 15;

            Assert.AreEqual(res, wait);
        }
    }
}
