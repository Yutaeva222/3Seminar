// Задача 17. Напишите программу, которая принимает на вход координаты точки X и Y, при чем они не равны 0,
// и выдает номер четверти плоскости, в которой находится эта точка.

double GetNumber(string name) // метод для ввода чисел координат 
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}
int GetNumChetv(double x, double y) // метод определения точки координат
{
    if (x > 0 && y > 0)
        return 1;
    else 
    if (x < 0 && y > 0)
        return 2;
    else
    if (x < 0 && y < 0)
        return 3;
    else return 4;
}

double x = GetNumber("X");
double y = GetNumber("Y");

Console.WriteLine("Это четверть " + GetNumChetv(x,y));
