// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.//
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = number / 10;
int number2 = number1 % 10;

Console.Write($"Вторая цифра трехзначного числа - {number2}");