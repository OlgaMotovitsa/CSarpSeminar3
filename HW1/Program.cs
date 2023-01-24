// 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом
Console.Clear();

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit1 = number / 10000;
int digit2 = (number / 1000) % 10;
int digit4 = (number % 100) / 10;
int digit5 = number % 10;

if (digit1 == digit5 && digit2 == digit4)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}