// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int ReadInt(string msg) // объявление функции
{
    System.Console.WriteLine(msg); // вывод на экран параметра msg функции
    string inputString = Console.ReadLine(); // считывает строку из консоли
    int number = int.Parse(inputString); // преобразует строку в число
    return number; // возврат значения
}


int DigitsSum (int inputNumber)
{
    int result = 0;
    
    for (int i = 1; inputNumber / i > 0; i *= 10)
    {
        result += inputNumber / i % 10;
    }
    return result;
}
int inNumber = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {inNumber} равна: {DigitsSum(inNumber)}");
