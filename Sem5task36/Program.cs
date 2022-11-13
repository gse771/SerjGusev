// Задать одномерный массив случайными числами. Найти сумму элементов, стоящих на неетных позициях
Console.WriteLine("Укажите нижнию границу массива");
int A =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите верхнию границу массива");
int B =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите размер массива");
int L  =Convert.ToInt32(Console.ReadLine());
int sum =0;
int [] array =new int[L];
for(int i =0; i<L; i++)
{
    array[i]=new Random().Next(A,B+1);
    Console.Write(array[i] +" , ");
    if (i%2==1)
    {
        sum +=array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма чисел, стоящих на неетных позициях = " + sum);