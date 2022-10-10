// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (-999,999);
    }
}
void PrintArray(int[]array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] array = new int[123];
FillArray(array);
PrintArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if  (array[i]>=10)
        {  
           if (array[i]<=99)                             
           {
             int count = 1;
             sum = sum + count;
           }
        }
}
Console.WriteLine();
Console.Write($"В массиве {sum} чисел от 10 до 99");