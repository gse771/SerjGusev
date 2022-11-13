// Задать массив, заполненный случайными трехзначными числами. Вывести сколько четных чисел в массиве
Console.WriteLine("Укажите размер массива");
int l= Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];
int count = 0;
for (int i =0; i<l;i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] +" , ");
    if (array[i]%2 ==0)
    {
        count +=1;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных элементов в массиве = " + count);