﻿// // Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int num = new Random().Next(0,int.MaxValue);
// введем принудительно число для проверки работы прграммы
//num = 16;

Console.WriteLine("Ваше число  "  + num);
if(num>=100)
{
    //конвертация числа в строку
    string num_str = num.ToString();
    //находим в строке (число) интересующий нас элемент, т.к это третья цифра, то номер позици будет равен 2
    char nomer = num_str[2];

    Console.WriteLine(nomer);
}
else
{
    Console.WriteLine("Третья цифра в данном числе отсутствует");
}



