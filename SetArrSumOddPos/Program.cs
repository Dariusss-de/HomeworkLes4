// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void SetArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
    int num =  new Random().Next(-100,100);
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

void SumNumOddPos(int[] array)
{
    int sum = 0;
    for(int i=0;i<array.Length;i++)
    {
        if(i%2 !=0)
        sum += array[i];
    }
    sum = sum + array[0];
    Console.WriteLine("Сумма элементов = "+sum);
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
SetArray(arr);
OutputOnTheSqreen(arr);
SumNumOddPos(arr);


