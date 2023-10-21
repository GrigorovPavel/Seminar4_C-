﻿// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] RandomArray (int min, int max, int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();  // При таком варианте допускается использование var rnd вместо Random rnd.
    // НЕОБХОДИМО создать объект(переменную Random rnd = new Random();), чтобы не создавать 
     // объекты памяти в каждой итеррации цикла!)
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
    
}

void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
}


int[] array = RandomArray(0,9,8);
PrintArray(array);
