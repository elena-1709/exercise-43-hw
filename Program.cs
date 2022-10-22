// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем


void PrintIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine($"Прямые параллельные"); 
    }    
     else
     {
        double x = (b1 + b2) / (k2 + k1); 
        double y = k2 * x + b2;
        x = Math.Round(x);
        y = Math.Round(y);
        Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
     }   
       
}
    
Console.Clear();
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);    
Console.Write ("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!); 
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write ("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!); 

PrintIntersection(b1, k1, b2, k2);

