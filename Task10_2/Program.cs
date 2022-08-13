/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Введите трёхзначное число");
int num=Convert.ToInt32(Console.ReadLine());
int a =Math.Abs(num);
string stringNum=Convert.ToString(a);
if(stringNum.Length<3||stringNum.Length>3)
{
    Console.WriteLine("Это не трёхзначное число");
}
else
{
  Console.WriteLine("Вторая цифра числа - "+stringNum[1]);  
}