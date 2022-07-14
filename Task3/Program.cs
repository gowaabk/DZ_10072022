/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);

        }
    }
    return answer;
}

void AverageColumns(int[,] array)           //Поиска средне арифметического п остолбцам
{
    System.Console.WriteLine("Среднее арифметическое по столбцам");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avgSumColumns = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {

            avgSumColumns = avgSumColumns + array[i, j];
            //System.Console.WriteLine(avgSumColumns + " " + array[i, j]);
        }
        System.Console.Write($"{Math.Round(avgSumColumns / (array.GetLength(0)), 2)}\t ");
    }
    return;
}

void PrintArray(int[,] array)       // Вывод массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("введите количество столбцов > ");
int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);
System.Console.WriteLine();

AverageColumns(myArray);
