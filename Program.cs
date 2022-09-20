/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.Write($"Наибольшим числом из введённых двух является число {number1}, а наименьшим является число {number2}.");
}

else if (number1 < number2)
{
    Console.Write($"Наибольшим числом из введённых двух является число {number2}, а наименьшим является число {number1}.");
}

if (number1 == number2)
{
    Console.Write($"Наши числа равны");
}

---

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"Максимальное число {max}");

--

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write($"{number} чётное.");
}

else
{
    Console.Write($"{number} нечётное.");
}

Console.Write("Задача выполнена.");

---

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());

    for (int i = 1; i <= number; i++)
    if (i % 2 == 0)
Console.Write("{0} ", i);*/