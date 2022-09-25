/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

int m = 6, n = 4;

int[,] FillRandomArray(int m, int n)
{
    int[,] randomArray = new int[m, n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(1, 9);
        }
    }
    return randomArray;
}

int[,] randomArray = FillRandomArray(m, n);


Console.WriteLine("Заданный массив: ");

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        Console.Write(randomArray[i, j] + " ");
    }
    Console.WriteLine();
}

int tmp = 0;
for (int i = 0; i < randomArray.GetLength(1); i++)
{
    tmp = randomArray[0, i];
    randomArray[0, i] = randomArray[randomArray.GetLength(0) - 1, i];
    randomArray[randomArray.GetLength(0) - 1, i] = tmp;
}

Console.WriteLine();
Console.WriteLine("Массив с замененными строками: ");

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        Console.Write(randomArray[i, j] + " ");
    }
    Console.WriteLine();
}
