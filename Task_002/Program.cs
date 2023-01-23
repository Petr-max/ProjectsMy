// Задача 2: 
// Напишите программу, которая на вход 
// принимает два числа и выдает,
// какое число большее, а какое меньшее.
// a = 5, b = 7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = a;

if (a > b)
{
  max = a; min = b;
}
else
{
  max = b; min = a;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
