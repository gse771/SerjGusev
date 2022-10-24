// Даны координаты двух точек в трёхмерном пространстве. Найти Расстояние м/д этими точками
Console.WriteLine("Введите координату X первой точки");
int x1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
int y1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
int z1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки");
int x2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
int y2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
int z2= Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты первой точки:  " + x1 + "," +y1+ ","+ z1 );
Console.WriteLine();
Console.Write("Координаты второй точки:  " + x2 + "," +y2+ ","+ z2 );
double R = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)+ Math.Pow(z1-z2,2));
Console.WriteLine();
Console.WriteLine("Расстояние м/д точками =  "+R);