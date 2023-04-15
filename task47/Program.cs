// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// Пример: m = 3, n = 4.

// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1   9

Console.WriteLine("Задайте размеры двухмерного массива: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

double[,] array = GenerateArray2D(m, n);
PrintArray(array);

double[,] GenerateArray2D(int m, int n)
{
   double[,] array = new double[m, n];
   Random rand = new Random();

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         // array[i, j] = Math.Round((rand.Next(-9, 10) + rand.NextDouble()), 1);
         array[i, j] = (double)rand.Next(-99, 100) / 10;
      }
   }
   return array;
}

void PrintArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      Console.WriteLine();
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i, j].ToString().Length == 1) { Console.Write($"{array[i, j]}     "); }
         else if (array[i, j].ToString().Length == 2) { Console.Write($"{array[i, j]}    "); }
         else if (array[i, j].ToString().Length == 3) { Console.Write($"{array[i, j]}   "); }
         else { Console.Write($"{array[i, j]}  "); }
      }
   }
}

