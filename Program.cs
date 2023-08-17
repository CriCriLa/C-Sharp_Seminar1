// Напишите программу, которая на вход 
// принимает число и выдает его квадрат.
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32 (Console.ReadLine());
// int num2 = number * number;
// Console.WriteLine(num2);

// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int num2 = Convert.ToInt32 (Console.ReadLine());

// if (num1==num2*num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Написать программу, которая будет выдавать 
// название дня недели по заданному номеру.

// Console.Clear();
// Console.WriteLine("Введите число от 1 до 7:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num==1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (num==2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (num==3)
// {
//     Console.WriteLine("Среда");
// }
// else if (num==4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (num==5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (num==6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (num==7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня недели у нас нет.");
// }

// Программа на вход принимает число N, 
// а на выходе показывает все целые числа в промежутке от -N до N.]

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int negNumber = -1*num;

// while (negNumber<=num)
// {
//     Console.WriteLine(negNumber);
//     negNumber = negNumber+1;
// }

// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает последнюю цифру этого числа. 
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int result = num%10;
Console.WriteLine(result);

