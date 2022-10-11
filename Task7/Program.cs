// В Указанном массиве вещественных чисел найдите 
// разницу между максимальным и минимальным элементом
void PrintArray (double[] array)
{
   for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}| ");
}
double [] array = {5.2, 3.3, -2.8, -3.7, 0.25};
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
  if (array[i]>max) max = array[i];
}
for (int i = 0; i < array.Length; i++)
{
  if (array[i]<min) min = array[i];
}

double result = max-min;
Console.WriteLine("Ваш массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine ($"Разница между максимальным и минимальным элементами массива |{result}|");
