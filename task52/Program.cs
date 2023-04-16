// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: [4,6; 5,6; 3,6; 3]

Console.WriteLine("Задайте размеры двухмерного массива: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] array = GenerateArray2D(m, n);
PrintArray2D(array);
Console.WriteLine();
Console.WriteLine("Среднее арифмитическое строк");
double[] array1DString = AverageString(array);
PrintArray(array1DString);
Console.WriteLine();
Console.WriteLine("Среднее арифмитическое столбцов");
double[] array1DColumn = AverageColumn(array);
PrintArray(array1DColumn);

int[,] GenerateArray2D(int m, int n)
{
   int[,] array = new int[m, n];
   Random rand = new Random();

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = rand.Next(1, 100);
      }
   }
   return array;
}

void PrintArray2D(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      Console.WriteLine();
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i, j].ToString().Length == 1) { Console.Write($"{array[i, j]}     "); }
         else if (array[i, j].ToString().Length == 2) { Console.Write($"{array[i, j]}    "); }
         else { Console.Write($"{array[i, j]}   "); }
      }
   }
}

double[] AverageString(int[,] array)
{
   double[] array1D = new double[array.GetLength(0)];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      double sum = 0;
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array1D[i] = Math.Round((sum += array[i, j]) / array.GetLength(1), 2);
      }
   }
   return array1D;
}

double[] AverageColumn(int[,] array)
{
   double[] array1D = new double[array.GetLength(1)];
   for (int i = 0; i < array.GetLength(1); i++)
   {
      double sum = 0;
      for (int j = 0; j < array.GetLength(0); j++)
      {
         array1D[i] = Math.Round((sum += array[j, i]) / array.GetLength(0), 2);
      }
   }
   return array1D;
}

void PrintArray(double[] array)
{
   Console.Write($"[{string.Join(";  ", array)}]");
}