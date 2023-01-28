// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void SetArray(double[] array)
{
    for(int i=0;i<array.Length;i++)
    {
    double num =  new Random().NextDouble()*100;
    array[i] = num;
    }
}
void OutputOnTheSqreen(double[] array)
{
   foreach(double item in array)
   {
   Console.Write($" {item} ");
   }
   Console.WriteLine();
   
}

void DiffMaxMin(double[] array)
{
    double result;
    double max =array[0];
    double min = array[0];
    for(int i = 0;i<array.Length;i++)
    {
        if(array[i]>max) max = array[i];
        if(array[i]<min) min = array[i];
    }
    result = max - min;
    Console.WriteLine("Разница max и min = "+result);

}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] arr = new double[size];
SetArray(arr);
OutputOnTheSqreen(arr);
DiffMaxMin(arr);

