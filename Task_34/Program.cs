/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


int [] generateArray (int length, int start, int end)
{
    int [] result = new int [length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}

int getIntFromUser (string massage)
{
    Console.WriteLine(massage);
    int userInt = int.Parse(Console.ReadLine()!);
}

int [] positiveArray (int [] arreyTol)
{
    for (int i = 0; i < arreyTol.Length; i++)
    {
        if (arreyTol[i] % 2 == 0);
    }
    return arreyTol;
}

void printArray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array(i));
        if (i < array.Length - 1)
        {
            Console.Write("]");
        }
    }
}

int length = getIntFromUser ("Введите длину массива:");
int [] arrey = generateArray (length, 100, 999);
printArray(arrey);
int [] sumPositive = positiveArray(arrey);
printArray (sumPositive);
Console.WriteLine ($"колличество четных чисел в массиве:");