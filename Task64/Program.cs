// Задать значения M и Nю Программа.ю которая выводит все натуральные числа в промежутке от M до N
Console.WriteLine("Укажите наименьшее число M");
int M =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите наибольшее число N");
int N =Convert.ToInt32(Console.ReadLine());

string PrintNumber(int start,int end)
{
    if(start==end)
    {
        return end.ToString();        
    }
    if(start>end)
    {
        return "введите корректные значения M и N";        
    }
    return (start+" "+PrintNumber(start+1,end));
}
Console.WriteLine("--");
Console.WriteLine(PrintNumber(M,N));