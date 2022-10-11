// Найти произведение пар чисел в одномерном массиве. 


void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Задайте длину массива");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте диапазон чисел массива [min,max]");
Console.WriteLine("Введите min");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите max");
int max = int.Parse(Console.ReadLine() ?? "0");
int [] array = new int[n];

FillArray(array, min, max);
PrintArray (array);
Console.WriteLine();
Console.Write("Произведения парных чисел массива: ");
int product = 0;
for (int i = 0; i < n/2; i++)
{ 
    product = array[i]*array[n-1-i];
    Console.Write($"{product} ");
}
   





