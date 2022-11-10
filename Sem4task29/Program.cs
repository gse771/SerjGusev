// задать  масив из 8 элементов и вывести его на экран
Console.WriteLine("Введите минимальное значение в формируемом массиве ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение в формируемом массиве");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер массиве");
int С = Convert.ToInt32(Console.ReadLine());

int[] array=BbArray(С);
int [] BbArray(int size)
{
    int[] array = new int [size];
    for(int i =0; i<size; i++)
    {
        array[i]= new Random().Next(A,B+1);
        
    }
    return array;    
}
Console.WriteLine(String.Join(",",array));
//Console.WriteLine(string.Join(", ", array));