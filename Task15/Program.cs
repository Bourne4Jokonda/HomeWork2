// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число ");
int number=Convert.ToInt32(Console.ReadLine());

if(number<6){
    Console.WriteLine($"День номер {number} не выходной");
}
if (number>5 && number<7)
    Console.WriteLine($"День номер {number} выходной");

if(number>7){
    Console.WriteLine("Введите число меньше 7");
}
