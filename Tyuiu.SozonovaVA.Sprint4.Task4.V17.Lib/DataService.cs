using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SozonovaVA.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; // кол-во строк
            int columns = matrix.Length / rows;   // кол-во столбцов 
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count += matrix[i, j];
                    }
                }
            }
            return count;
        }
    }
}
