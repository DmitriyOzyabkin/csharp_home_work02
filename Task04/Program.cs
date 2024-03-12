//  Задача 4: Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.




Console.Write("Enter number: ");
int initNumber = Convert.ToInt32(Console.ReadLine());
if (initNumber < 0)
{
    initNumber *= -1;
}

int lastDigit = initNumber % 10;
int digit = initNumber;

if (initNumber < 10)
{
    Console.Write(initNumber);
}
else
{
    while (initNumber > 10)
    {
        int rang = 1;
        digit = initNumber;
        while (digit > 9)
        {
            if (digit / 10 != 0)
            {
                rang *= 10;
                digit /= 10;
            }
        }
        Console.Write($"{digit}, ");
        initNumber -= digit * rang;
    }
    Console.Write(lastDigit);
}







// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите натуральное число N: ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         if (N < 10)
//         {
//             Console.WriteLine(N);
//         }
//         else
//         {
//             while (N > 0)
//             {
//                 int currentDigit = N % 10;
//                 N /= 10;
//                 if (N > 0)
//                 {
//                     Console.Write(currentDigit + ",");
//                 }
//                 else
//                 {
//                     Console.WriteLine(currentDigit);
//                 }
//             }
//         }
//     }
// }
