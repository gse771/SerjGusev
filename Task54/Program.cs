// Задать 2-мерный массив. Упорядочить по убыванию элементы каждой строки.

Console.WriteLine("Укажите число строк массива");
int rows =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число столбцов массива");
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
                      
            //Console.Write(matrix[i,j] + "   ");
        }
        //Console.WriteLine();
    }    
    return matrix;
}
Console.WriteLine();
int maxnam;
int box;
int [,] gg = MadeMatrix(rows, columns, min, max);

Console.WriteLine();

int jmax;
    for(int i =0; i<rows; i++)
    {
        for (int k=0; k<columns; k++)
        {
            jmax=0;
            maxnam = gg[i,k];
            for(int j=k+1; j<columns; j++)
            {           
                if(gg[i,j]>maxnam)
                {
                    maxnam=gg[i,j];
                    jmax=j;
                }
            }
                box=gg[i,k];
                gg[i,k]=maxnam;
                gg[i,jmax]=box;
                
        
            Console.Write(gg[i,k] + "   "); 
               
        }
         Console.WriteLine();
    }    
  
    
    
    

