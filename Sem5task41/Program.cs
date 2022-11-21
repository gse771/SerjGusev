// Пользователь с клавиатуры вводит М чисел. Посчитать сколько положительных чисел ввел пользователь
Console.Write("Задайте ряд любых чисел с клавиатуры, используя в качестве разделителя между вводимыми чисоами запятую  :  ");
string text =Console.ReadLine();
Console.WriteLine(text);
Console.WriteLine();

int StrLenght = text.Length;
int i = 0;
int Plus_ = 0; // Количество положительных чисел в строке
string char_ = string.Empty;
while (i < StrLenght)
{
    if (text[i] != ',')
        {
            char_ = char_ + text[i];
        }
    else
        {
//            Console.WriteLine(char_);
             if (Convert.ToInt32(char_) > 0)
                {
                    Plus_ = Plus_ + 1;
                }
            char_ = string.Empty;   
        }
    i++;
}
//Console.WriteLine(char_);
if (Convert.ToInt32(char_) > 0)
    {
        Plus_ = Plus_ + 1;
    }
Console.Write("Всео положительных чисел в строке: ");
Console.WriteLine(Plus_);