using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VegerinaVV.Sprint4.Task2.V13.Lib
{
    public class DataService : ISprint4Task2V13
    {
        public int Calculate(int[] array)
        {
            int multArray = 1;
            for(int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    multArray *= array[i];
                }
            }
            return multArray;
        }
    }
}
