// Решение в группах:
// Напишите программу, которое 
// будет выдавать название дня недели
// по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
switch (namber)
{
  case 1:
    Console.WriteLine("Это понедельник: ");
    break;
  case 2:
    Console.WriteLine("Это вторник: ");
    break;
  case 3:
    Console.WriteLine("Это среда: ");
    break;
  case 4:
    Console.WriteLine("Это четверг: ");
    break;
  case 5:
    Console.WriteLine("Это пятница: ");
    break;
  case 6:
    Console.WriteLine("Это суббота: ");
    break;
  case 7:
    Console.WriteLine("Это воскрессенье: ");
    break;
  default:
    Console.WriteLine("Введено некоректное значение: ");
    break;
}
