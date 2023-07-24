// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа 
// от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Hello, write the number: N = ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write($"{num} -> ");
int i = 1;

 if (num % 2 == 1)
{
    num -= 1; //num=num-1
}

while (i <= num)
{
    if (i % 2 == 0 && i < num)
    {
        Console.Write(i + ", ");
    }
    else if (i == num && i % 2 == 0) Console.WriteLine(i);

    i++;
}