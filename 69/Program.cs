// 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

Console.Clear();

Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите степень числа A, В: ");
int degree = int.Parse(Console.ReadLine() ?? "");

int result = DegreeNum(number, degree);
Console.WriteLine($"А = {number}; В = {degree} -> {result}");

//=============================

int DegreeNum(int num, int deg)
{
    if (deg == 0)
    {
        return 1;
    }

    else if (deg == 1)
    {
        return num;
    }

    else
    {
        return num * DegreeNum(num, deg - 1);
    }
}