// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int Exponentiation(int numA, int numB) // Метод возведения в степень.
{
    int count = 0;
    int temp = 1;
    while(count < numB)
    {
        temp = temp * numA;
        count++;
    }
    return temp;
}

Console.WriteLine("Введите число которое будет возводится в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которую будет возводится число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} = {exponentiation}");