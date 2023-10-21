// Напишите программу, которая
// 1. принимает на вход числоа и  
// 2. выдает сумму чисел от 1 до А
// 7->28
// 4->10
// 8->36



int SumNumbers(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
          sum = sum + i;  
        }
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)  //проверка на натуральность числа
{
    Console.WriteLine("Некорректный ввод");
    return; // Завершает МЕТОД и возвращает к месту вызова МЕТОДА
}

int sumNumber = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumber}");


