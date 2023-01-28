// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void SetArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
    int num =  new Random().Next(100,999);
    array[i] = num;
    }
}
void OutputOnTheSqreen(int[] array)
{
   foreach(int item in array)
   {
   Console.Write($" {item} ");
   }
   Console.WriteLine();
}

void EvenOdd(int[] array)
{
    int evenNum = 0;
    int oddNum = 0;
    
    for(int i = 0;i<array.Length;i++)
        if(array[i]%2 == 0) evenNum++;
         Console.WriteLine("Количество чётных чисел = "+evenNum);
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
SetArray(arr);
OutputOnTheSqreen(arr);
EvenOdd(arr);