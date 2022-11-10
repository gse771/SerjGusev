// написать цикл, который принимает на вход два числа и возводит первое число в натуральную степень, определяемую вторым числом

Console.WriteLine("Введите первое натуральное число A");
double A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число B");
double B = Convert.ToInt32(Console.ReadLine());

double Stepen = A;
Console.WriteLine();
Console.WriteLine(Stepen);

for(int i=1; i<=B-1; i++ )
{
    Stepen *=A;
    //Console.WriteLine();
    //Console.WriteLine("А " );
    Console.WriteLine(Stepen);
}
Console.WriteLine();
Console.WriteLine("А в степени В =  " + Stepen);