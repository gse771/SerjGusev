// Массив вещественные числа. Найти разницу между минимальным и максимальным элементами массива
Console.WriteLine("Укажите нижнию границу массива");
int A =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите верхнию границу массива");
int B =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите размер массива");
int L  =Convert.ToInt32(Console.ReadLine());
double min =0;
double max =0;
double [] array =new double[L];
for(int i =0; i<L; i++)
{
    array[i]=new Random().Next(A,B+1);
    Console.Write(array[i] +" , ");
    if (array[1] > min)
    {
//        min=min;
    }
    else
    {
        min =array[i];
    }
    if (array[i]>max)
    {
        max=array[i];
    }
    else
    {
 //       max=max;
    }

}
Console.WriteLine();
Console.WriteLine("Минимальное число =  " + min);
Console.WriteLine("Максимальное число =  " + max );