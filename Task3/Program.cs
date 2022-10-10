// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

void FillArray(int[] array)
{
   int length = array.Length;
   for (int i = 0; i < length; i++)
   {   
      array[i] = new Random().Next(100,999);
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
int[] array = new int[5];
FillArray(array);
PrintArray(array);
int sum = 0;
int sum1 = 0;

for (int i = 0; i < array.Length; i++)
{    
    if (array[i]%2==0)
    {
       int count = 1; 
       sum = sum + count;
       count++;
    }
    else
    {
       int count = 1; 
       sum1 = sum1 + count;
       count++;
    }
}
Console.WriteLine();
Console.WriteLine($"В массиве {sum} четных чисел и {sum1} нечетных чисел");




    
