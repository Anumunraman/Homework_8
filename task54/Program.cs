namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha54()
            {
                 /* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/ 
                int rows = 4;
                int columns = 7;
                int[,] array = new int[rows,columns];

                FillArray(array);
                PrintArray(array);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int k =0; k < columns - j - 1; k++)
                        {
                            if (array[i,k] < array[i,k+1])
                            {
                                int temp = array[i,k];
                                array[i, k] = array[i, k + 1];
                                array[i,k + 1] = temp; 
                            }
                        }
                    }
                }

                PrintArray(array);

                
            
            }
            Zadacha54();
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




 