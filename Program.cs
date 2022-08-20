//Урок 4. Функции продолжение
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int Exponentials(int numi1, int numi2)
{
    int expont = 1;
    for (int i = 0; i < numi2; i++)
    {
        expont = expont * numi1;
    }
    return expont;
}

Console.WriteLine("Please input number to exponentiate: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input exponent number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {num1} in {num2} exponent equals {Exponentials(num1, num2)}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int SumDigits(int mainNum)
{
    int sum = 0;
    while (mainNum != 0)
    {
        int digi = mainNum % 10;
        mainNum = (mainNum / 10);
        sum = sum + digi;
    }
    return sum;
}

Console.Write("Please input your number: ");
int number = (Convert.ToInt32(Console.ReadLine()));

Console.Write($"The sum of all digits of {number} is {SumDigits(number)}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//Добавила возможность регулировать диапазон значений рандомных элеметов =)
/*
void StartArray(int dlina, int val1, int val2)
{
    int[] array = new int[dlina];
    Random rnd = new Random();
    for (int i = 0; i < dlina; i++)
    {
        array[i] = rnd.Next(val1, val2);
        //Console.WriteLine($"The value of the {i + 1}th element of our array is {array[i]}");
        Console.Write($"{array[i]}  ");
    }
}

Console.WriteLine("Please input a value of array's length");
int lenarr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input the 1st value of array's random elements range");
int range1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input the 2nd value of array's random elements range");
int range2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"This is our array of {lenarr} random elements:");
StartArray(lenarr, range1, range2);
*/