using Tyuiu.VegerinaVV.Sprint4.Task3.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 3 до 7. Подсчитайте количество   *");
        Console.WriteLine("* четных элементов во всем массиве.                                       *");
        Console.WriteLine("*                                                                         *");

        int[,] mtrx = new int[5, 5] { { 4, 3, 5, 5, 3 },
                                      { 6, 7, 4, 4, 3 },
                                      { 3, 3, 7, 3, 6 },
                                      { 3, 4, 3, 7, 7 },
                                      { 3, 5, 6, 3, 6 }};
        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(mtrx);

        Console.WriteLine("Количество четных элементов массива = " + res);
        Console.ReadKey();
    }
}