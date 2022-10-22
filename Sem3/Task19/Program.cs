// На ввод пятизначное число. Проверить, является ли число полиндромом: да или нет.
Console.WriteLine("Введите любое пятизначное число");

int num = Convert.ToInt32(Console.ReadLine());
if(num<10000||num>99999)
{
    Console.WriteLine("Ошибка ввода числа");
}
else{
    string num_str = num.ToString();
    if(num_str[0]==num_str[4]&&num_str[1]== num_str[3])
    {
      Console.WriteLine("Да, это число является полиндромом");
    }
    else
    {
    Console.WriteLine("Нет, это число не является полиндромом");
    }
}
    