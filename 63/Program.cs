// 63. Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.

Console.Clear(); 

Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine() ?? "");
int i = 1;
Numbers(num, i);

//=========================================

void Numbers(int N, int j)
{
    if(j < N)
    {
        Console.Write($"{j}, ");
        Numbers(N, j + 1);
    }
    else if (j == N)
    {
        Console.Write($"{j}!");
    }
}