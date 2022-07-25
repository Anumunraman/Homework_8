namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha56()
            {
                /* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
                int rows = 4;
                int columns = 7;
                int[,] array = new int[rows,columns];

                FillArray(array);
                PrintArray(array);

                

                int sumMin = 0;
                int sumMinIndex = 0;

                for (int j = 0; j < columns; j++)
                {
                    sumMin += array[0,j];
                }
                Console.WriteLine($"Сумма 1-й строки равна: {sumMin}");

                for (int i = 1; i < rows; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < columns; j++)
                    {
                        sum += array[i,j];
                    }
                    Console.WriteLine($"Сумма {i+1}-й строки равна: {sum}");

                    if (sum < sumMin)
                    {
                        sumMin = sum;
                        sumMinIndex = i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Минимальная сумма находится в строке {sumMinIndex+1} и равна {sumMin}");
            
            }
            Zadacha56();
        }
        static void FillArray(int[,] array)
        {
            Random random = new Random();
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    array[i, j]=random.Next(0,100);
                }
            }
        }
        static void PrintArray(int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine("Вывод массива: ");
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}




 