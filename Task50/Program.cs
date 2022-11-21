// Написать программу, которая на вход принимает позицию элемента двухмерного массива и возвращает значение этого 
//элемента или же указание, что данного элемента нет

Console.WriteLine("Задайте минимаальное значение числа в массиве");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное значение числа в массиве");
int max =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное количество строк в массиве");
int maxrow =Convert.ToInt32(Console.ReadLine());
int row=new Random().Next(maxrow+1);
Console.WriteLine("Задайте максимальное количество столбцов в массиве");
int maxcolumn =Convert.ToInt32(Console.ReadLine());
int column=new Random().Next(maxcolumn+1);
Console.WriteLine();
int [,] matrix = new int[row,column];

//Console.WriteLine(matrix.GetLength(0));
//Console.WriteLine(matrix.GetLength(1));
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j]=new Random().Next(min,max+1);
        Console.Write(matrix[i,j] + "   ");
    }
    Console.WriteLine();
}
Console.WriteLine("Укажите номер строки элемента");
int sti=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите номер столбца элемента");
int stj=Convert.ToInt32(Console.ReadLine());
if(sti<=matrix.GetLength(0)&&stj<=matrix.GetLength(1))
{
    
    Console.WriteLine("Элемент = "+ matrix[sti,stj]);
}
else
{
    Console.WriteLine(" Такого числа в массиве нет");
}


