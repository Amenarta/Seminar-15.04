/*

// Задача №1: Написать программу, которая выводит случайное число из отрезкаот 10 до 99 вкл.и показывает наибольшую цифру в этом числе.

void shownumber ()
{
    int num = new Random().Next(10, 99);
    int firstnum = num/10;
    int secondnum = num%10;

    Console.Write(num + "-> ");

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

// Задача №2: Программа должна выводить 3-хзначное число и удалять вторую цифру этого числа.

void shownumber ()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + " -> ");
    int num1 = num/100;
    int num2 = num%10;
    int num3 = num1*10 + num2;

    Console.Write(num3);
}  
shownumber();

// Задача №3: Программа, которая на вход принимает 2 числа и проверяет яв-ся ли 2-е число квадратом первого.

void ifmultiple()
{
    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 % num2 == 0)
        {
            Console.Write(num1 + " кратно " + num2);
        }
    else 
    {
        Console.Write(num1 + " не кратно " + num2);
    }
}
ifmultiple(); */

// Задача №3: Программа, которая принимает число и проверяет одновременно кратно ли оно 7 и 23.

void task (int num)
{    
    if (num%7 == 0 && num%23 ==0)
    {
        Console.Write(num + " является кратным 7 и 23");
    }
    else
    {
        Console.Write(num + " не является кратным 7 и 23");
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
task (num);

/*
// Задача №4. Программа, которая на вход принимает 2 числа и проверяет яв-ся ли одно число квадратом другого.

void square ()
{
    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int quad = num2 * num2;
if(num1 == quad)
    {
        Console.WriteLine("Первое число является квадратом второго числа");
    }
else
    {
        Console.WriteLine("Первое число не является квадратом второго числа");
    }
}
square ();
*/