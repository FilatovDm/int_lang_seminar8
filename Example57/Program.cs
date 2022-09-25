/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 } - 0 встречается 2 раза, 1 встречается 1 раз, 2 встречается 1 раз, 8 встречается 1 раз, 9 встречается 3 раза
*/

int m = 4, n = 3;

int[,] FillRandomArray(int m, int n)
{
    int[,] randomArray = new int[m, n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(0, 20);
        }
    }
    return randomArray;
}

int[,] array = FillRandomArray(m, n);

Console.WriteLine("Заданный массив: ");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int minElem = array[0, 0];
int maxElem = array[0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minElem) minElem = array[i, j];
        else if (array[i, j] > maxElem) maxElem = array[i, j];
    }
    
}

Console.WriteLine("Максимальный элемент: " + maxElem);
Console.WriteLine("Минимальный элемент: " + minElem);

int countElem = 0;
for (int e = minElem; e <= maxElem; e++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == e) countElem = countElem + 1;
        }
    
    }
    if (countElem > 0)
    {
        Console.WriteLine($"{e} встречается {countElem} раз");
        countElem = 0;
    }
}
