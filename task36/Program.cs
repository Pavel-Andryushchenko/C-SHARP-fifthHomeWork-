// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumEvenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
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
int[] array = GetRandomArray(size, -100, 101);
Console.WriteLine($"[{string.Join(" ,", array)}] -> {GetSumEvenNumbers(array)}");