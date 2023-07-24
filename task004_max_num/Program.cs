// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Hello, write the first number:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Hello, write the second number:");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Hello, write the third number:");
int num3 = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int max = 0;

if(num1 > num2 && num1 > num3)
{
    max = num1;
    Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");
}
else if(num2 > num1 && num2 > num3)
{
    max = num2;
    Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");
}
else if(num3 > num1 && num3 > num2)
{
    max = num3;
    Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");
}
else
{
    Console.WriteLine($"{num1}, {num2}, {num3} -> The numbers are equal");    
}