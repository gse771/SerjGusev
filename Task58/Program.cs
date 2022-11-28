//  Задать две матрицы и найти их произведение
Console.WriteLine("Укажите число строк 1-ой матрицы");
int rows1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число столбцов 1-ой матрицы, и это число будет определять число строк 2-ой матрицы");
int columns1 =Convert.ToInt32(Console.ReadLine());
int rows2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число столбцов 2-ой матрицы");
int columns2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите минимальное натуральное число в 1-ой матрице");
int min1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите максимальное натуральное число в 1-ой матрице");
int max1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите минимальное натуральное число во 2-ой матрице");
int min2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите максимальное натуральное число во 2-ой матрице");
int max2 =Convert.ToInt32(Console.ReadLine());
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

int[,] gg1 =MadeMatrix(rows1, columns1, min1, max1);
Console.WriteLine();
int[,] gg2 =MadeMatrix(rows2, columns2, min2, max2);
Console.WriteLine();

int [,] matrix = new int [rows1, columns2];
int b=0;
for (int k=0; k<rows1; k++)
    {
    for(int j=0; j<columns1; j++)
        {
            b=0;
            for(int i=0; i<columns1; i++)
            {
                //Console.Write(gg1[k,i] + " * "+ gg2[i,j]+ " - ");
                //Console.WriteLine();
                b=b+gg1[k,i] * gg2[i,j];
                matrix[k,j]=b;
            }
            matrix[k,j]=b;
            Console.WriteLine(matrix[k,j]+"("+k+","+j+")");
            Console.WriteLine();
           
        }
    }

for(int i=0; i<matrix.GetLength(0); i++)
    {      
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "   ");
            
        }
    Console.WriteLine();
    }    