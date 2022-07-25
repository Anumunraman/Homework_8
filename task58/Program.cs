namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha58()
            {
                /* Задача 58. Заполните спирально массив 4 на 4.*/
                Random random = new Random();
                int rows = random.Next(4,8);
                int columns = random.Next(4,8);
                int[,] array = new int[rows,columns];

                int index_i = 0;
                int index_j = 0;

                int change_i = 0;
                int change_j = 1;

                int steps = columns;
                int turnCount = 0;
                                
                for (int i = 1; i <= array.Length; i++)
                {
                    array[index_i, index_j] = i;
                    Console.Write(array[index_i,index_j] + "\t");
                    steps--;
                    if (steps == 0)
                    {
                        steps = columns * (turnCount % 2) + rows * ((turnCount + 1) % 2) - 1 - turnCount/2;

                        int temp = change_i;
                        change_i = change_j;
                        change_j = -temp;
                        turnCount++;
                    }

                    index_i += change_i;
                    index_j += change_j;
                }
                Console.WriteLine();
                PrintArray(array);
                
            
            }
            Zadacha58();
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




 