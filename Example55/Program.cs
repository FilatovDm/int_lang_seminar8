/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int m = 4, n = 4;

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


if ( m == n)
{
Console.WriteLine("Заданный массив: ");

for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        Console.Write(randomArray[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] newArray = new int[randomArray.GetLength(0), randomArray.GetLength(1)];
for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        newArray[i, j] = randomArray[j, i];
    }
    
}

Console.WriteLine();
Console.WriteLine("Массив с замененными строками: ");

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        Console.Write(newArray[i, j] + " ");
    }
    Console.WriteLine();
}
}

else
{
    Console.WriteLine("Заменить строки на столбцы невозможно! Количество столбцов должно быть равно количеству строк");
}
