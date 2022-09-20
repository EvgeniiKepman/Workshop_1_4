// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Clear();

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int num = 2;
if (number<0)
        while (num <= -number)
    {
        Console.WriteLine($"{num}, ");
        num = num + 2;
        }
else{
        while (num <= number)
    {
        Console.WriteLine($"{num}, ");
        num = num + 2;
        }
        }