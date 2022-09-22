/*
    Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    452 -> 11
    82 -> 10
    9012 -> 12
    // int counter = Convert.ToString(MyArray).Length;
*/

Console.WriteLine("Введите сумму: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    int a = number % 10;

    number = number / 10;
    sum = sum + a;
}

Console.WriteLine(sum);