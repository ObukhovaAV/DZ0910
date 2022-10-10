// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] collection)
{
   int count = collection.Length;
   for (int pos = 0; pos < count; pos++)
   {
      collection[pos] = new Random().Next(-9,10);
   }
}
void PrintArray(int [] collection)
{
    int count = collection.Length;
    for (int pos = 0; pos < count; pos++)
    {
       Console.Write($" {collection[pos]} ");
    }
}
int[] collection = new int[12];

FillArray (collection);
PrintArray(collection);

int length = collection.Length;
int sumplus = 0;
int summinus = 0;

for (int pos = 0; pos < length; pos++)
{ 
    if (collection[pos]>0)
    {      
      sumplus = sumplus+collection[pos];
    }
    else 
    {
        summinus = summinus+collection[pos];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма положительных чисел массива - " + sumplus);
Console.WriteLine("Сумма отрицательных  чисел массива - " + summinus);

