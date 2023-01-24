// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

Console.Clear();

int num = new Random().Next(1,10);
System.Console.WriteLine($"num = {num}");

for(int i = 1; i <= num; i ++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}
