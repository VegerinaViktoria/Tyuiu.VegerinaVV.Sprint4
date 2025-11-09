using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VegerinaVV.Sprint4.Task6.V14.Lib
{
    public class DataService : ISprint4Task6V14
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length > 3);
            return mas;
        }
    }
}
