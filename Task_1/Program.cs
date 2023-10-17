// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int MyExponention (int inputNumber, int inputExp)
{
    int result = 1;
    for (int i = 0; i < inputExp; i++)
    {
        result *= inputNumber;
    }
    return result;
}
int a = 3;
int b = 5;
System.Console.WriteLine($"{a} в степени {b} = {MyExponention(3, 5)}");
