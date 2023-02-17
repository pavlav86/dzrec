// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Recursion(int num)
{
  if (num == 1)
  {
    Console.Write(num);
    return;
  }
  Console.Write($"{num}, ");
  Recursion(num - 1);
}

int GetNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int number = GetNumber("Enter the number: ");
Console.Write($"N = {number} -> ");
Recursion(number);