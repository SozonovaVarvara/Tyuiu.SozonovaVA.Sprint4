using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SozonovaVA.Sprint4.Task5.V25.Lib
{
    public class DataService : ISprint4Task5V25
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            int str = matrix.Length / matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < str; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count += matrix[i, j];
                    }
                }
            }
            return count;
        }
    }
}
