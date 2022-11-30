//Задать M и N. Найти сумму натуральных чисел от M до N.

Console.WriteLine("Укажите число M");
int M =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число N");
int N =Convert.ToInt32(Console.ReadLine());

int PrintNumber(int n1,int n2)
{
    if(n1==n2)
    {
        return n2;        
    }
    if(n1>n2)
    {
        int box=0;
        box=n1;
        n1=n2;
        n2=box;       
        return (n1+PrintNumber(n1+1,n2));
    }
    return (n1+PrintNumber(n1+1,n2));
}
Console.WriteLine("--");
Console.WriteLine(PrintNumber(M,N));