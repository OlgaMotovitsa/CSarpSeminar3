// Напишите программу, которая принимает на вход координаты 2х точек 
// и находит расстояние между ними в 3Д пространстве.

// точка А (3,6,8)
// точка B (2,1,-7)
// ответ = 15.84

Console.Clear();

Random rnd = new Random();
int x1 = rnd.Next(1,11);
int y1 = rnd.Next(1,11);
int z1 = rnd.Next(1,11);
int x2 = rnd.Next(1,11);
int y2 = rnd.Next(1,11);
int z2 = rnd.Next(1,11);

System.Console.WriteLine($"x1 = {x1}, y1 = {y1}, z1 = {z1}, x2 = {x2}, y2 = {y2}, z2 = {z2}");

double result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));

System.Console.WriteLine(result);