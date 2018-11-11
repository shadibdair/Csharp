using System;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] matrix = new string[3][];
            for (int i = 0; i < matrix.Length; i++)
            {
                int center = 0;
                matrix[i] = new string[3];
                center = (int)(matrix[i].Length / 2);
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == j && i != center)
                        matrix[i][j] = "Main";
                    else if (i != center && (i + j == matrix.Length - 1))
                        matrix[i][j] = "Sub";
                    else if (i < j)
                        matrix[i][j] = "Up";
                    else if (i > j)
                        matrix[i][j] = "Down";
                    else
                        matrix[i][j] = "Center";
                }

            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    Console.Write($"{matrix[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}


