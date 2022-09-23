// Задача21. Программа, которая принимает на вход координаты двух точек и находит расстояние 
// между ними.MathSqr().
Console.Clear();
double GetNumber(string name) // метод для ввода чисел координат 
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}

double GetDistance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
    return distance; 
}

double x1 = GetNumber("X1");
double y1 = GetNumber("Y1");
double x2 = GetNumber("X2");
double y2 = GetNumber("Y2");

Console.WriteLine("Расстояние между точками = " + GetDistance(x1,x2,y1,y2));