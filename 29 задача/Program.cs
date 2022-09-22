/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] MyArray;
MyArray = new int[8];
int index = 0;
int a = 1;

for (int i = 0; i < MyArray.Length; i++)
{
    Console.Write($"Введите {a} число: ");
    MyArray[i] = int.Parse(Console.ReadLine());
    a++;
}

Console.Write("Массив = [ ");
while (index < MyArray.Length)
{
    Console.Write($"{MyArray[index]}, ");
    index++;
}
Console.Write("]");
Console.WriteLine();