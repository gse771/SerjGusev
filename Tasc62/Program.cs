// Заполнить спирально массив 4*4


    
    int[,] matrix=new int[4,4];
    int b=0;
    
    for(int j=0; j<4; j++)
    {      
        int i=0;
        matrix[i,j]=b+1;
        b=matrix[i,j];
        //Console.Write(matrix[i,j] +"("+i+","+j+")");
        
    } 
    //Console.WriteLine();
    
        for(int i=1; i<4; i++)
        {
            int j=3;
            matrix[i,j] =b+1;
            b=matrix[i,j];
            //Console.Write(matrix[i,j] +"("+i+","+j+")");
        }
        //Console.WriteLine();
            for(int j=2; j>=0; j=j-1)
            {
                int i =3;
                matrix[i,j]=b+1;
                b=matrix[i,j];
                //Console.Write(matrix[i,j] +"("+i+","+j+")");
                
            }
            //Console.WriteLine();
                    for(int i=2; i>0; i=i-1)
                    {
                        int j=0;
                        matrix[i,j]=b+1;
                        b=matrix[i,j];
                        //Console.Write(matrix[i,j] +"("+i+","+j+")");
                        
                    } 
                    //Console.WriteLine();    
    for(int j=1; j<3; j++)
    {      
        int i=1;
        matrix[i,j]=b+1;
        b=matrix[i,j];
        //Console.Write(matrix[i,j] +"("+i+","+j+")");
        
    }
    //Console.WriteLine(); 
    for(int i=2; i<3; i++)
    {
        int j=2;
        matrix[i,j] =b+1;
        b=matrix[i,j];
        //Console.Write(matrix[i,j] +"("+i+","+j+")");
        
    }
    //Console.WriteLine();
    for(int j=1; j>=1; j=j-1)
    {
        int i =2;
        matrix[i,j]=b+1;
        b=matrix[i,j];
        //Console.Write(matrix[i,j] +"("+i+","+j+")");
    }
    //Console.WriteLine();
for (int i=0; i<4; i++)
{
    for(int j=0; j<4; j++)
    {
        Console.Write(matrix[i,j]+ "\t");
    }
    Console.WriteLine();
}    