// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Fill in a number: ");
int i = Convert.ToInt32(Console.ReadLine());
int summ = 0;

while (i > 0)
    {
        int n = i % 10;
        i = i / 10;
        summ = summ + n;
    }
Console.WriteLine("The answer is: " + summ); 
