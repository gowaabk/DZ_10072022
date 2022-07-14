/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

 */

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max) //Генерация массива
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

void FindXYInArray(int[,] array, int findX, int findY)      // Функция поиска числа в массиве по координатам.
{
    if (findY <= array.GetLength(1) && findY >= 0 && findX <= array.GetLength(0) && findX >= 0)
    {
        int num = array[findX - 1, findY - 1];
        System.Console.WriteLine($"в позиции {findX}, {findY} находится элемент {num}");
        return;

    }
    else System.Console.WriteLine("Такого элемента нет в массиве");
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
int findX = Prompt("Введите номер позиции эл-та по X > ");
int findY = Prompt("Введите номер позиции эл-та по Y > ");
FindXYInArray(myArray, findX, findY);
