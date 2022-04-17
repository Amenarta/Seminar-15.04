// Задача №1: Написать программу, которая выводит случайное число из отрезкаот 10 до 99 вкл.и показывает наибольшую цифру в этом числе.

void shownumber ()
{
    int num = new Random().Next(10, 99);
    int firstnum = num/10;
    int secondnum = num%10;

    Console.Write(num + "->");

    if (firstnum > secondnum)
    {
        Console.WriteLine(firstnum);
    }
    else
    {
        Console.WriteLine(secondnum);
    }
}
shownumber();