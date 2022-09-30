using static System.Console;
Clear();
WriteLine("Введите число которое будем возводить в степень: ");
int num1 = int.Parse(ReadLine()!);
WriteLine("Введите степень в которую будем возводить ранее введенное число: ");
int num2 = int.Parse(ReadLine()!);
int numdegree = GetDegreeNumber(num1, num2);
WriteLine($"Число {num1} возведенное в степень {num2} равно {numdegree}");








int GetDegreeNumber(int number, int degree)
{
    int result = number;
    while (degree > 1)
    {
        result *= number;
        degree--;
    }
    return result;
}