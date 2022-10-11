// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
      Random N = new Random();
      array [i] = N.Next(min, max);
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

Console.WriteLine("Задайте диапазон массива [min, max]");
Console.WriteLine("Введите min");
int min = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите max");
int max = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[n];

FillArray( array, min, max);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2==1)
    {
       sum = sum + array[i];
    }
    else
    {
      sum = sum+0;
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях, равна  {sum}");
