// На вход число на выход сумма цифр в числе

Console.WriteLine("Введите целое число ");
int B = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int Summa(int sum1)
{
    if(B>10)
    {
           
        while(B>10)
            {
                sum1 += B%10;
                //Console.WriteLine(sum1);
                B /=10;
                      
            }
            sum1 +=B;
    }
    else
    {
        
        sum1 +=B;
    }
    
return sum1;

}
Console.WriteLine(Summa(sum));


