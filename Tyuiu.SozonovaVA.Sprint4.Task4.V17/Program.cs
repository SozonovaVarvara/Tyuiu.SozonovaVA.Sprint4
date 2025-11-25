using Tyuiu.SozonovaVA.Sprint4.Task4.V17.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        Console.Title = "Спринт #4 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 7. Найдите сумму четных     *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Введите количество столбцов:                                              *");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество строк:                                                 *");
        int y = Convert.ToInt32(Console.ReadLine());


        int[,] arr = new int[x, y];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int column = i + 1;
                int row = j + 1;
                Console.WriteLine("Введите значение для " + column + " столбца " + row + " строки");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(arr));
    }
}