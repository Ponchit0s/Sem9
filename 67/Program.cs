// 67. Напишите программу, которая на вход будет прнимать число
// и возвращать сумму его цифр.

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");

int sum = SumNumbers(number);
Console.WriteLine($"{number} -> {sum}");

//=============================

int SumNumbers(int num)
{
    if(num == 0)
    {
        return 0;
    }

    return num % 10 + SumNumbers(num / 10);
}