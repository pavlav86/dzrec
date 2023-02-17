// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RecSum(int m, int n)
{
  int sum = 0;
  if (m == n) return n;
  return sum + m + RecSum(m + 1, n);
}

int GetNumber(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int start = GetNumber("Enter the first number: ");
int finish = GetNumber("Enter the second number: ");
int sum = RecSum(start, finish);
Console.WriteLine($"M = {start}; N = {finish} -> {sum}");
