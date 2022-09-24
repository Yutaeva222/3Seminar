// Задача на таблицу квадратов введенного числа. 
Console.Clear();
int GetNumber() // метод введения числа и возврата его в программу.
{
   Console.WriteLine("Введите число: ");
   return Convert.ToInt32(Console.ReadLine());

}
void GetPrintPow(int number)
{
    int count = 1;
    Console.WriteLine("Таблица квадратов до числа " + number + ": ");
    while (count <= number)
    {
    Console.Write(Math.Pow((count),2) + " ");
    count++;
    }
}
GetPrintPow(GetNumber());