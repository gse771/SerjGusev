// Задача 4 семинар1
Console.WriteLine("Введите первое число");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namber3 = Convert.ToInt32(Console.ReadLine());

if(namber1>=namber2)
{
    if(namber1>=namber3)
    {
        Console.Write("max - ");
        Console.WriteLine(namber1);
    }
    else
    {
        Console.Write("max - ");
        Console.WriteLine(namber3);  
    }
}
else
{   if(namber2>=namber3)
    {
        Console.Write("max - ");
        Console.WriteLine(namber2);
    }
    else
    {
        Console.Write("max - ");
        Console.WriteLine(namber3);  
    }
}
          