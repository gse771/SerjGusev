// Задача 37 с семинараНа основе одномерного ассива создать новый масив - произведене пар (первый с последним, второй с предпоследним и тд)
Console.WriteLine("Укажите нижнию границу массива");
int A =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите верхнию границу массива");
int B =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите размер массива");
int L  =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [] array1 =new int[L];
int L2=L/2+L%2;
int[] array2 = new int[L2];
for(int i =0; i<L; i++)
{
    array1[i]=new Random().Next(A,B+1);
    Console.Write(array1[i] +" , ");
    
}
Console.WriteLine();
for(int i=0; i<L2; i++)
{
    if(i==L-1-i)
    {
        array2[i]=array1[i];
        Console.Write(array2[i]);

    }
    else
    {
        array2[i] =array1[i] *array1[L-1-i];
        Console.Write(array2[i] +" , ");

    }

 
}

