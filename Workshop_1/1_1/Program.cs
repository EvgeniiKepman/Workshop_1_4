// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7 min = 5
// a = 2 b = 10 -> max = 10 min = 2
// a = -9 b = -3 -> max = -3 min = -9
Console.WriteLine("Введите число 1: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.WriteLine("Введите число 2: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
if (number1 > number2)
{
    Console.WriteLine($"{number1} = max");
    Console.WriteLine($"{number2} = min");
}
else
{
    Console.WriteLine($"{number2} = max");
    Console.WriteLine($"{number1} = min");
}