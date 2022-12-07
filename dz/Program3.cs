//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
for (int b = 1; b <= a; b++)
{ 
    Console.Write($"{b*b*b} ");
}
