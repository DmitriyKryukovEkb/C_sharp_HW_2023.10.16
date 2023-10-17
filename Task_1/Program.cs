// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int ReadInt(string msg) // объявление функции
{
    System.Console.WriteLine(msg); // вывод на экран параметра msg функции
    string inputString = Console.ReadLine(); // считывает строку из консоли
    int number = int.Parse(inputString); // преобразует строку в число
    return number; // возврат значения
}

int MyExponention(int inputNumber, int inputExp)
{
    if (inputExp > 0)
    {
        int result = 1;
        for (int i = 0; i < inputExp; i++)
        {
            result *= inputNumber;
        }
        return result;
    }
    else 
    {
        throw new InvalidOperationException("Нужна натуральная степень");
    }
}

int inNumber = ReadInt("Введите целое число для возведения в степень");
int inExp = ReadInt("Введите степень (только положительное целое число)");
System.Console.WriteLine($"{inNumber} в степени {inExp} = {MyExponention(inNumber, inExp)}");
