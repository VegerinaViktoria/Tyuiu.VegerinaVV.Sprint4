using Tyuiu.VegerinaVV.Sprint4.Task0.V12.Lib;

namespace Tyuiu.VegerinaVV.Sprint4.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 2 };
            int res = ds.GetMultEvenArrEl(numsArray);
            int wait = 768;

            Assert.AreEqual(wait, res);
        }
    }
}
