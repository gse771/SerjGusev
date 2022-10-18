// // Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int num = new Random().Next(0,int.MaxValue);
// введем принудительно число для проверки работы прграммы
//num = -537326291;

Console.WriteLine("Ваше число  "  + num);
// на случай ручного ввода отрицательного числа рассматриваем модуль числа
//Console.WriteLine("Введите любое целое число");
//int num = Convert.ToInt32(Console.ReadLine());
if(Math.Abs(num)<100)
{
    Console.Write("Третья цифра в данном числе отсутствует");
}
else
{
    int num3 = Math.Abs(num);
        
    while((num3/10)>=100)
    {
        num3 = num3/10;
                
    }
    Console.Write("Третья цифра числа -   "   +   num3%10);
}

   

