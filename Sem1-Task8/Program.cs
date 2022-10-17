// Задача 8 семинар1
Console.WriteLine("Введите любое положитеьное число");
int namber1 = Convert.ToInt32(Console.ReadLine());
int begin = 1;
if(namber1<=0)
{
    Console.Write("Недопустимое значение");
}
else
{
    while(begin<=namber1) 
    {
        if(begin %2 ==0)  
        {
            Console.WriteLine(begin);
            begin++;
        }
        else
        {
            begin++;
        }

    }
} 
