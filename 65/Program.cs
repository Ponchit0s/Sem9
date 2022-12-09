// 65. Задайте значения M и N. Напишите програму, которая
// выведет все натуральные числа в промежутке от M до N.\

Console.Clear(); 

Console.Write("Введите число M: ");
int num1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число N: ");
int num2 = int.Parse(Console.ReadLine() ?? "");

Numbers(num1, num2);

//=========================================

void Numbers(int M, int N)
{
    if(M < N)
    {
        Console.Write($"{M}, ");
        Numbers(M + 1, N);
    }
    else if (M == N)
    {
        Console.Write($"{M}!");
    }
}