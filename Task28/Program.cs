// Напишите программу, которая
// 1. принимает на вход числоа и  
// 2. выдает произведение чисел от 1 до А
// 4->24
// 5->120

int MultNumbers(int num)
{
    int count = 1;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
          count = count * i;  
        }
    }
    return count;
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)  //проверка на натуральность числа
{
    Console.WriteLine("Некорректный ввод");
    return; // Завершает МЕТОД и возвращает к месту вызова МЕТОДА
}

int multNumber = MultNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multNumber}");