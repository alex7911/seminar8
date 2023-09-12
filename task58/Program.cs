/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
// Ввод в консоль                                 
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
//Заполнение массива рандомными числами
void Fill2DArray(int[,] array)
{
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }  
    }
}
//Выводим в консоль массив
void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();  
    }  
}
//Находим произведение двух матриц
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
   
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
//Ввод данных в консоль
int rowFirstMatrix = InputNum("Введите число строк 1-й матрицы: ");
int columnFirstMatrix = InputNum("Введите число столбцов 1-й матрицы/строк 2-й: ");
int columnSecomdMatrix = InputNum("Введите число столбцов 2-й матрицы: ");

//Вывод
int[,] firstMartrix = new int[rowFirstMatrix, columnFirstMatrix];
Fill2DArray(firstMartrix);

Console.WriteLine($"Первая матрица:");
Print2DArray(firstMartrix);

int[,] secomdMartrix = new int[columnFirstMatrix, columnSecomdMatrix];
Fill2DArray(secomdMartrix);

Console.WriteLine($"Вторая матрица:");
Print2DArray(secomdMartrix);

if(rowFirstMatrix != columnFirstMatrix || 
    columnFirstMatrix != columnSecomdMatrix || 
            rowFirstMatrix != columnSecomdMatrix)
{
    Console.WriteLine(" Нельзя перемножить ");
}
else 
{
int[,] resultMatrix = new int[rowFirstMatrix,columnSecomdMatrix];    
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);

Console.WriteLine($"Произведение первой и второй матриц:");
Print2DArray(resultMatrix);
}
