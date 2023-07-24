// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Hello, write the first number:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the second number:");
int b = int.Parse(Console.ReadLine()!);
int max = 0;

if(a > b)
{
    max = a;
    Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
}
else if(a < b)
{
    max = b;
    Console.WriteLine($"a = {a}; b = {b} -> max = {b}");
}
else
{
    Console.WriteLine($"a = {a}; b = {b} -> a = b");
}