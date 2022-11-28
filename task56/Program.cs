// See https://Дан 2-мерный массив -прямоугольный. Найти номер строки  с наименьшей суммой элементов

Console.WriteLine("Укажите число строк массива");
int rows =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число столбцов (отличное от числа строк) массива");
int columns =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите минимальное натуральное число в массиве");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите максимальное натуральное число в массиве");
int max =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] MadeMatrix (int rows, int columns, int min, int max)
{    
    int[,] matrix=new int[rows,columns];
    for(int i=0; i<matrix.GetLength(0); i++)
    {      
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(min,max+1);
                    
            Console.Write(matrix[i,j] + "   ");
            
        }
         
        Console.WriteLine();
    }    
    return matrix;
}

int  CountMatrix (int [,] matr)
{
    int sum;    
    int minsum = int.MaxValue;
    int imin=0;
    for(int i=0; i<matr.GetLength(0); i++)
    {
        sum = 0;      
        for(int j=0; j<matr.GetLength(1); j++)
        {
            sum = sum + matr[i,j];
            //Console.Write(sum+"  ");
        }            
        if (sum < minsum) 
        {
            minsum=sum;
            imin=i;
        }
            //Console.WriteLine("  "+sum+"--" +imin);
            
    }
        Console.WriteLine("Номер строки с минимальной суммой элементов равна "+(imin+1)); 
        Console.WriteLine();
    return imin;     
}    

int[,] gg =MadeMatrix(rows, columns, min, max);
int ss= CountMatrix(gg);
