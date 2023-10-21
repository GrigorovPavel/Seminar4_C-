// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int num)
{
    int count = 0;
    int temp = 0;
    while(count < num)
    {
        temp = temp + num % 10;
        num = num / 10;
        count++;
    }
    return temp;
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine($"Cумма цифр в числе {number} -> {sumDigit}");