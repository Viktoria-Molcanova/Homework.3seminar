//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine());
int a=n;
int b =0;
int sum = 0;
while ( n > 0)
{
b = n % 10;
sum = (sum * 10) + b;
n = n / 10; 

}
if( a == sum )
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}

