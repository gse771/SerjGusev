// Задать двухмерный массив m*n и заполнив его случайными вещественными числами
Console.WriteLine("Задайте минимаальное значение числа в массиве");
double min =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте максимальное значение числа в массиве");
double max =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте количество срок в массиве");
int row =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в массиве");
int column =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double [,] matrix = new double[row,column];

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j]=new Random().NextDouble()*(max-min)+min;
        Console.Write(matrix[i,j] + "   ");
    }
    Console.WriteLine();
}
