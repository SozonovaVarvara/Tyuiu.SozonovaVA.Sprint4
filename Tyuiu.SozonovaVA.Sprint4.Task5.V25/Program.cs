using Tyuiu.SozonovaVA.Sprint4.Task5.V25.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random random = new Random();

        Console.Title = "Спринт #4 | Выполнила: Созонова В. А. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы                                                 *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
        Console.WriteLine("* заполненный случайными значениями в диапазоне от -4 до 3.               *");
        Console.WriteLine("* Найдите сумме чисел больше 0                                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите колличество строк");
        int str = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите колличество столбцов");
        int stl = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[str, stl];
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stl; j++)
            {

                array[i, j] = random.Next(-4, 3);
            }
        }
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < str; ++i)
        {
            for (int j = 0; j < stl; j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int z = ds.Calculate(array);
        Console.WriteLine(z);

        Console.ReadKey();
    }
}