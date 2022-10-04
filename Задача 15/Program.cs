


/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


Console.Write("Введите число месяца: ");
int InpDayOfWeek = int.Parse(Console.ReadLine());

//InpDayOfWeek = (InpDayOfWeek % 7) + 7 - (InpDayOfWeek % 7);

if (InpDayOfWeek % 7 == 0 || InpDayOfWeek % 6 == 0)
{
    Console.Write("Этот деня является выходным!");
}
else
{
    Console.WriteLine("Не выходной");
}