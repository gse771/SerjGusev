// Найти координаты точки пересечения двух прямых, заданных уравнениями: y=k1*x+b1; y=k2*x+b2. Значения задаются пользователем
Console.WriteLine("Укажите коэфициент k1");
double k1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите постоянную b1");
double b1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите коэфициент k2, не равный k1");
double k2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите постоянную b2");
double b2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Уравнение для первой прямой: y="+k1+"*x+"+b1);
Console.WriteLine("Уравнение для второй прямой: y="+k2+"*x+"+ b2);


if(k1==k2)
{
    
    if(b1==b2)
    {
        
        Console.Write("Прямые совпадают");
    }
    else{
        Console.Write("Прямые параллельны");
    }
}
else
{
    double x =(b2-b1)/(k1-k2);

    Console.WriteLine();
    Console.WriteLine("Координаты точки пересечения:(" +x+";"+x+")");
    Console.WriteLine();
}    



