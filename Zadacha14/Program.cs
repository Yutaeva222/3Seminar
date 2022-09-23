// Программа, которая проверяет число, кратно ли оно одновременно 7 и 23.

Console.Clear();

int GetNumber() // метод введения числа и возврата его в программу.
{
   Console.WriteLine("Введите число: ");
   int a = Convert.ToInt32(Console.ReadLine());
   return a;
}
bool CheckMod(int a, int mod) // мод это переменная, определяющая число на которое будет проверять деление.
{
    return (a % mod == 0);
}

int a = GetNumber(); // присвоили результат метода числу а.
if (CheckMod(a,7) && CheckMod(a,23))
   Console.WriteLine("Верно, это число делится на 7 и на 23.");


// bool result;
// bool del7 = (a % 7 == 0);
// bool del23 = (a % 23 == 0);

// result = (del7 && del23);
// if (result)     
//      Console.WriteLine ("Верно, это число делится на 7 и на 23. ");


// if (a % 7 == 0)
// {
//     del7 = true;;
// }
// else 
// {
//     del7 = false;
// }
// if (a % 23 == 0)
// {
//     del23 = true;;
// }
// else 
// {
//     del23 = false;
// }
// if (del7==true && del23==true)
// {
//     
// }
// 