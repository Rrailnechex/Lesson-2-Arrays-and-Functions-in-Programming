


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите число: ");
int AFull = int.Parse(Console.ReadLine());


int S1 = AFull / 100;
Console.Write("Сотни = ");
Console.WriteLine(S1);

int D1 = AFull / 10;
int D2 = D1 % 10;
Console.Write("Десятки = ");
Console.WriteLine(D2);

int E1 = AFull % 10;
Console.Write("Еденицы = ");
Console.WriteLine(E1);