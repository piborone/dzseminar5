// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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
int chet = 0;
    int[] array = new int[razmerprov];
    for(int i = 0; i < razmerprov; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if(array[i] % 2 == 0)
        {
         chet++;
        }
    }
    System.Console.WriteLine("случайный массив");
    Console.WriteLine($"[{String.Join("; ", array)}]");
    System.Console.WriteLine("кол-во четных элементов " + chet);
