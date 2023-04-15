// Задача 50.Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7]->такого числа в массиве нет

Console.WriteLine("Задайте размеры двухмерного массива: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] array = GenerateArray2D(m, n);
PrintArray2D(array);
Console.WriteLine();

Console.WriteLine("Задайте первый индекс элемента: ");
int firstIndex = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второй индекс элемента: ");
int secondIndex = int.Parse(Console.ReadLine());

ElementSearch(array, firstIndex, secondIndex);

int[,] GenerateArray2D(int m, int n)
{
   int[,] array = new int[m, n];
   Random rand = new Random();

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = rand.Next(-99, 100);
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

void ElementSearch(int[,] array, int index1, int index2)
{
   if (index1 < array.GetLength(0) && index2 < array.GetLength(1))
   {
      Console.Write($"Число на позиции [{index1},{index2}] -> {array[index1, index2]}");
   }
   else
   {
      Console.Write($"Числа на позиции [{index1},{index2}] не существует");
   }
}
