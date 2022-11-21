// Задать двухмерный массив из целых чисел. Найти среднеарифметическое элементов в каждом столбц
Console.WriteLine("Укажите число строк массива");
int row =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число столбцов массива");
int column =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите минимальное натуральное число в массиве");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите максимальное натуральное число в массиве");
int max =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix=new int[row,column];
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j]=new Random().Next(min,max+1);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
  
for(int j =0; j<column; j++)
{
       
    double summ=0;
    for(int i=0; i<row; i++)
    {
        summ=(summ+matrix[i,j]);
        
    }
    Console.Write(summ/row + "\t");
    
}
    
    

     
    





