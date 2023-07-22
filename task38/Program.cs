// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void GetMaxMin(int[] arr, out int max, out int min)
{
    min = arr[0];
    max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) 
        {
            min = arr[i];
        }
        else 
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
    }
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
int[] array = GetRandomArray(size, 0, 100);
Console.Write($"[{string.Join("; ", array)}] => ");
int maxValue, minValue;
GetMaxMin(array, out maxValue, out minValue);
Console.WriteLine($"{maxValue} - {minValue} = {maxValue - minValue} ");

