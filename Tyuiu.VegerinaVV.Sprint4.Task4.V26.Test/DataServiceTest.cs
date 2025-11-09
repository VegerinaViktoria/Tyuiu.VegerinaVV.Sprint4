using Tyuiu.VegerinaVV.Sprint4.Task4.V26.Lib;

namespace Tyuiu.VegerinaVV.Sprint4.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 1, 2, 3, 4, 5 },
                                            { 2, 3, 1, 4, 4 },
                                            { 1, 3, 3, 2, 4 },
                                            { 3, 1, 4, 5, 5 },
                                            { 5, 4, 3, 2, 1 } };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = { { 0, 2, 0, 4, 0 },
                            { 2, 0, 0, 4, 4 },
                            { 0, 0, 0, 2, 4 },
                            { 0, 0, 4, 0, 0 },
                            { 0, 4, 0, 2, 0 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
