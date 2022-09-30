using static System.Console;
Clear();
WriteLine("Введите число: ");
int num = int.Parse(ReadLine()!);
int summa = GetSumma(num);
WriteLine($"Сумма цифр числа {num} равна {summa}");









int GetSumma(int number)
{
    int result = 0;
    int temp = 0;
    while (number > 0)
    {
        temp = number % 10;
        result = result + temp;
        number = number / 10;
    }
    return result;
}