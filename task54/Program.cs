/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
// Ввод в консоль                                 
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
//Создание двумерного массива
int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}
//Заполнение массива рандомными числами
void Fill2DArray(int[,] array)
{
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10, 100);
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
//Сортировка элементов в строке двумерного массива по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
//Ввод данных в консоль
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
//Вывод
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray);
Print2DArray(myArray);
Console.WriteLine();
SortToLower(myArray);
Print2DArray(myArray);
