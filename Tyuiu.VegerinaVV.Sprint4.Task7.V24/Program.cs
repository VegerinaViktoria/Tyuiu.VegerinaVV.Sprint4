using Tyuiu.VegerinaVV.Sprint4.Task7.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"651827384219648\". Преобразуйте ее  *");
        Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
        Console.WriteLine("*                                                                         *");

        int n = 5;
        int m = 3;
        int[,] mtrx = new int[n, m];

        string str = "651827384219648";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int index = 0;

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(n, m, str);

        Console.WriteLine("Произведение четных чисел = " + res);
        Console.ReadKey();
    }
}