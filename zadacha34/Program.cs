// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int Razmer(int numbers) // определение положительной длинны массива
{
    if(numbers > 0)
    {
        
    }
    System.Console.WriteLine("Введеное значение не является положительным");// не прекращает работ у выводит пустой массив
      
return numbers;
}

int InputNumbers(string str)
{
    int numbers;
    string? text;
    while(true)
    {
        Console.WriteLine(str);
        text = Console.ReadLine();
        if(int.TryParse(text, out numbers))
        {
            break;
        }
        Console.WriteLine("Ошибка!!! Введено не верное значение!");
    }
    return numbers;
}

//Console.WriteLine("Введите необходимую длинну массива: ");
int razmer = InputNumbers("Введите необходимую длинну массива: ");
int razmerprov = Razmer(razmer);
int chet = 0;
//if(razmer > 0)
//{
    int[] array = new int[razmerprov];
    for(int i = 0; i < razmerprov; i++)
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
//}
//else
//{
//    System.Console.WriteLine("Введеное значение не является положительным");
//}
