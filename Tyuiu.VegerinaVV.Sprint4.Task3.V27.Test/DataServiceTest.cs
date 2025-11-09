using Tyuiu.VegerinaVV.Sprint4.Task3.V27.Lib;

namespace Tyuiu.VegerinaVV.Sprint4.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 3, 4, 5, 6, 7 },
                                          { 4, 5, 6, 7, 4 },
                                          { 3, 3, 4, 5, 5 },
                                          { 4, 4, 6, 6, 3 },
                                          { 3, 4, 6, 5, 7 } };

            int res = ds.Calculate(mas2);
            int wait = 12;

            Assert.AreEqual(wait, res);

        }
    }
}
