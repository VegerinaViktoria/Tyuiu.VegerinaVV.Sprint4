using Tyuiu.VegerinaVV.Sprint4.Task6.V14.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных [\"Январь\", \"Февраль\", \"Март\",         *");
        Console.WriteLine("* \"Апрель\", \"Май\", \"Июнь\", \"Июль\"], используя класс Array,        *");
        Console.WriteLine("* выведите элементы массива, длина которых больше 3 символа.              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        var month=new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

        Console.WriteLine("Исходный массив:");
        for (int i=0; i <= month.Length - 1; i++)
        {
            Console.WriteLine(month[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Элементы, длина которых больше 3:");

        string[] res = ds.Calculate(month);
        var str = string.Join(",", res);
        Console.WriteLine(str);
        Console.ReadKey();
    }
}