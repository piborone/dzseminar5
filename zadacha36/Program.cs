﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int Razmer(int numbers) // определение положительной длинны массива
{
        while(numbers < 1)
    {
        System.Console.WriteLine("Введеное значение не является положительным");
        System.Console.WriteLine("Введите необходимую длинну массива повторно: ");
        numbers = Convert.ToInt32(Console.ReadLine());
    }

return numbers;
}

Console.WriteLine("Введите необходимую длинну массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());
int razmerprov = Razmer(razmer);
double sum = 0;
int[] array = new int[razmerprov];

    for(int i = 0; i < razmerprov; i++)
    {
        array[i] = new Random().Next(0, 10);  
    }
    for(int i = 0; i < razmerprov; i+=2)
    {
        sum=sum+array[i];
    }
    System.Console.WriteLine("случайный массив");
    Console.WriteLine($"[{String.Join("; ", array)}]");
    System.Console.WriteLine("кол-во четных элементов " + sum);