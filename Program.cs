//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом. 
/* Console.Clear();
Console.WriteLine("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine());
int number1 = number%10;
int number2 = (number/10)%10;
int number4 = (number/1000)%10;
int number5 = number/10000;
if(number1 == number5 & number2 == number4)
    {
        Console.WriteLine("Число является палиндромом");
    }
else 
    {
        Console.WriteLine("Число не является палиндромом");
    } */


//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
/* Console.Clear();
Console.Write("Введите координату Х первой точки: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine())!;
Console.Write("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine())!;

Console.Write("Введите координату Х второй точки: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z второй точки: ");
int z2 = int.Parse(Console.ReadLine()!);

double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//l = Math.Round(l, 2);
Console.Write($"Длина отрезка равна {l:f2}"); */


//Напишите программу которая принимает на вход число (N) и выдает
//таблицу кубов чисел от 1 до N.
/* Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
while (count <= number)
{
    Console.Write(Math.Pow(count, 3));
    if (count != number)
        Console.Write(", ");
    count++;
} */
