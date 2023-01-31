// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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

double[] Random(int numbers)
{
    double[] array = new double[numbers];
        for(int i = 0; i < numbers; i++)
    {
        array[i] = new Random().Next(-10, 10); 
    }
    return array;
}

double Min(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
        min = array[i]; 
        }
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
        max = array[i]; 
        }
    }
    return max;
}

Console.WriteLine("Введите необходимую длинну массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());
int razmerprov = Razmer(razmer);
double[] array = Random(razmerprov);
double min = Min(array);
double max = Max(array);
double rezult = max - min;
System.Console.WriteLine("случайный массив");
Console.WriteLine($"[{String.Join("; ", array)}]");
System.Console.WriteLine($" min = {min} и max = {max}");
System.Console.WriteLine("разница между min и max элементами " + rezult);
