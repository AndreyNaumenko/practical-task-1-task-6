// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
string name = Console.ReadLine();
int number = Convert.ToInt32(name);

if(number %2 > 0)
{
    Console.WriteLine("Это число нечетное");
}
else
{
    Console.WriteLine("Это число четное");
}