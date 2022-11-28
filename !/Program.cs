//заполнить матрицу трехмерную неповторяющимися двухзначными числами вывести массив построчно. указав индексы
int [,,] matrix = new int[3,3,3];
int[] matrixoneline = new int[27];
for (int i=0; i<27; i++)
{
    matrixoneline[i]=0;
}

//Console.WriteLine();
bool flag;
int n1=0;
int b;
for (int i=0; i<3; i++)
{
    for (int j=0; j<3; j++)
    {
        for (int k=0; k<3; k++)
        {
            do
            {
                flag = false;
                b=new Random().Next(10,99);
                //Console.WriteLine(b);
 //               matrixoneline[n1]=b;
                for (int n=0; n<27; n++)
                {
                    //Console.Write(matrixoneline[n]+" ");
                    if (b==matrixoneline[n])
                    {
                        flag=true;
                        //Console.WriteLine("Повторяется");
                    }
                }
                //Console.WriteLine();
            } while (flag);
            matrix[i,j,k] = b;
            matrixoneline[n1]=b;
            n1++;
//            Console.WriteLine(b);
        }
    }
}

for (int k=0; k<3; k++)
{
    for (int i=0; i<3; i++)
    {
        for (int j=0; j<3; j++)
        {
            Console.Write(matrix[i,j,k] + "("+i+","+j+","+k+")" + " ");
        }
        Console.WriteLine();
    }
}