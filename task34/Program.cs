// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 ==0) count++;
    }
    return count;
}

int[] GetRandomArray(int elements, int start, int finish)
{
    int[] mas = new int[elements];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(start, finish);
    }
    return mas;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Введите размерность массива: ");
int[] array = GetRandomArray(size, 100, 1000);
Console.WriteLine($"[{string.Join(" ,", array)}] -> {GetEvenNumbers(array)}" );