using Tyuiu.SozonovaVA.Sprint4.Task1.V30.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат, и печатает его на экране.                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.WriteLine("Введите количество элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsarray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write("Введите значение " + i + " элемента массива: ");
            numsarray[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(numsarray[i] + "\t");

        }
        Console.WriteLine();


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsarray);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}