using Tyuiu.SozonovaVA.Sprint4.Task3.V24.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
        Console.WriteLine("* случайными значениями в диапазоне от 4 до 9 подсчитать сумму нечетных   *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите количество элемнтов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            array[i] = rnd.Next(4, 9);
        }

        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(array[i] + "\t");
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(array);

        Console.WriteLine("Сумма нечетных элементов массива = " + res);
        Console.ReadKey();
    }
}