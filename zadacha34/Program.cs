// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите необходимую длинну массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());
if(razmer > 0)
{
    int[] array = new int[razmer];
    int chet = 0;
    for(int i = 0; i < razmer; i++)
    {
    array[i] = new Random().Next(100, 1000);
        if(array[i]%2 == 0)
        {
        chet++;
        
        }
    }
    System.Console.WriteLine("случайный массив");
    Console.WriteLine($"[{String.Join("; ", array)}]");
    System.Console.WriteLine("кол-во четных элементов " + chet);
}
else
{
    System.Console.WriteLine("Введеное значение не является положительным");
}
