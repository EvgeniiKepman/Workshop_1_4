// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();

Console.WriteLine("Введите число 1: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.WriteLine("Введите число 2: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
Console.WriteLine("Введите число 3: ");
string input3 = Console.ReadLine();
int number3 = int.Parse(input3);

int max = number1;

if (number2 > max)
    max = number2;
if (number3 > max)
    max = number3;

Console.WriteLine($"{max} - максимальное число");