//  Задача 4: Напишите программу, которая на вход принимает натуральное число N,
//  а на выходе показывает его цифры через запятую.




using System.Data;

Console.Write("Enter number: ");
int initNumber = Convert.ToInt32(Console.ReadLine());

if (initNumber < 10)                    // Вывод числа в консоль, если оно меньше 10
{
    Console.Write(initNumber);          
}
else
{
    int rang = 0;
    int number = initNumber;
    while (number > 0)                  // опредеряем разрядность числа
    {
        number /= 10;
        rang++;
    }
    Console.WriteLine($"Rang = {rang}");

    while (rang > 0)                         // 4
    {
        if (rang != 1)
        {
            number = initNumber;                // 1234
            int i = 0;
            while (i < rang)                    // 2 < 3
            {
                int digit = number % 10;        // 2
                if (i == rang - 1)
                {
                    Console.Write(digit);
                    Console.Write(", ");
                }
                number /= 10; //1
                i++;                            // 3       
            }
            rang--;
        }
        else
        {
        Console.Write(initNumber % 10);
        rang--;
        }                        // 3
    }
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
