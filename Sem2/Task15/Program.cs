// задача 15: Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите любое число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if((number>8)||(number<1))
{
    Console.WriteLine("Ошибка");
}
else
{
    if(number<6)
    {
        Console.WriteLine("Число  " + number  +  "  -  Невыходной день");
    }
    else
    {
        Console.WriteLine("Число  " + number  +  "  -   Выходной день");
    }
}    