// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-99,99);
    }
}
void PrintArray(int[] array)
{
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}
Console.WriteLine("Задайте длину массива");
int n = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[n];
FillArray(array);
PrintArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2==1)
    {
       sum = sum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях, равна  {sum}");
