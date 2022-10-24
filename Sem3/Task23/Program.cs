//  Принимает на вход число (N) и выдает таблицу кубов чисел от1 до N
int N = new Random().Next(1,20);
Console.WriteLine("Выбрано число  "+N);
double kub=1;
int count=1;
while(count<=N)
{
    kub=Math.Pow(count,3);
    Console.Write(kub+"    ");
    count=count+1;
}