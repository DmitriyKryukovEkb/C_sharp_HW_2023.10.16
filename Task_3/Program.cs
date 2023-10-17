// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] createMassive(int length, int min, int max) // создаем массив случайных чисел от min до max
{
    int[] massive = new int [length];
    max += 1;
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(min, max);
    }
    return massive;
}


void printMassive(int[] massive)
{
    foreach (var item in massive) // цикл для работы с массивом
    {
        Console.Write(item + " ");
    }
}
printMassive(createMassive(8, 0, 20));