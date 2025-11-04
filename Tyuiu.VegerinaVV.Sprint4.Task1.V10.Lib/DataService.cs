using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VegerinaVV.Sprint4.Task1.V10.Lib
{
    public class DataService : ISprint4Task1V10
    {
        public int Calculate(int[] array)
        {
            int multArray = 1;
            for (int i=0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    multArray *= array[i];
                }
            }
            return multArray;
        }
    }
}
