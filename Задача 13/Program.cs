


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Write("Введите число: ");
string Inp3Number = Console.ReadLine();


if (int.Parse(Inp3Number) <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    char[] New3Number = Inp3Number.ToCharArray();
    Array.Reverse(New3Number);

    //перевернуть число
    int.Parse(New3Number);
    int iteration = 0;
    for (int i = 0; i < New3Number.Length; i++)
    {
        iteration = iteration + New3Number[i] * Convert.ToInt32(Math.Pow(10, New3Number.Length - i - 1));
    }


    int S1 = int.Parse(New3Number) / 100;
    //Console.WriteLine((int.Parse(New3Number)));

    Console.Write("Третие число = ");
    Console.Write(S1 % 10);

}



/*
int S1 = New3Number / 100;
int D1 = New3Number / 10;
int D2 = D1 % 10;
int E1 = New3Number % 10;



Console.WriteLine(S1);





/*
int S1 = AFull / 100;
int D1 = AFull / 10;
int D2 = D1 % 10;
int E1 = AFull % 10;


int[] TheArray = new int[NumberLength];
TheArray[0] = S1;
TheArray[1] = D2;
TheArray[2] = E1;
Array.Reverse(TheArray);

Console.WriteLine(TheArray[100]);
Console.WriteLine(TheArray[99]);
Console.WriteLine(TheArray[98]);


if (Inp3Number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{

}




/*
уверен чт где то есть простое решение по типу функции Array.Get3rdNomberFromStart() но я его незнаю
и поэтому пишу через сотню исключений


int TherdNumber = 0;

if (Inp3Number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int TempResult = 0;
    if (Inp3Number >= 100 && Inp3Number <= 999)
    {
        int S1 = Inp3Number / 100;
        TempResult = S1
    }
    if (Inp3Number >= 1000 && Inp3Number <= 9999)
    {

    }
    if (Inp3Number >= 10000 && Inp3Number <= 99999)
    {

    }
    if (Inp3Number >= 100000 && Inp3Number <= 999999)
    {

    }
    if (Inp3Number >= 1000000 && Inp3Number <= 9999999)
    {

    }
    if (Inp3Number >= 10000000 && Inp3Number <= 99999999)
    {

    }
    else { Console.WriteLine("Число слишком большое"); }
    TherdNumber = TempResult;
}
*/



/* 
Console.WriteLine("------------------------------");

int[] TheArray = { -1, -1, -1 };
if (TheArray[0] != -1) { TheArray[0] = S1; }
if (TheArray[0] != -1) { TheArray[1] = D2; }
if (TheArray[0] != -1) { TheArray[2] = E1; }


//if (TheArray[0] != -1) { Console.WriteLine(TheArray[0]); }
//if (TheArray[0] != -1) { Console.WriteLine(TheArray[1]); }
//if (TheArray[0] != -1) { Console.WriteLine(TheArray[2]); }

Console.WriteLine(TheArray[0]);
Console.WriteLine(TheArray[1]);
Console.WriteLine(TheArray[2]);
*/