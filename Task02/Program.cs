﻿// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


Console.Write("Введите координату х (не должна ровняться 0): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у (не должна ровняться 0): ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.Write("Недопустимый ввод координат");
}
else if (x > 0 && y > 0)
{
     Console.Write($"Точка с координатами ({x}, {y}) принадлежит I четверти");
}
else if (x < 0 && y > 0)
{
     Console.Write($"Точка с координатами ({x}, {y}) принадлежит II четверти");
}
else if (x < 0 && y < 0)
{
     Console.Write($"Точка с координатами ({x}, {y}) принадлежит III четверти");
}
else if (x > 0 && y < 0)
{
     Console.Write($"Точка с координатами ({x}, {y}) принадлежит IV четверти");
}

