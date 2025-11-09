using Tyuiu.VegerinaVV.Sprint4.Task7.V24.Lib;

namespace Tyuiu.VegerinaVV.Sprint4.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "651827384219648";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 1179648;
            Assert.AreEqual(wait, res);
        }
    }
}
