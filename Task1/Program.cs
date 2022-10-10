// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random(). Next(0,2);     
    }    
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
    }
}
int[] array = new int [8];
FillArray(array);
PrintArray(array);