﻿// Задача 10 Программа принимает на вход трехзначное число, на выходе показывает вторую цифру введенного числа
int num = new Random().Next(100,1000);
Console.Write("Выпавшее число равно " + num);
Console.WriteLine(" Вторая цифра данного числа равна " + num/10%10);

