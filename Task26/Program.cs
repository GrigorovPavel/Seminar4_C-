// Напишите программу, которая
// 1. принимает на вход число и 
// 2. выдает количество цифр в числе
//456->3
//78->2
//89126->5

int CountNumber(int num)
{
    if(num == 0) return 1;

    int count = 0; //счетчик =0 (количество цифр в числе для начала расчета)
    while (num != 0)  // пока число != 0 делим его на десять(уменьшаем)
    {
        num = num / 10;
        count++;   //  и с каждым уменьшение прибавляем 1 в count
    }
    return count;  //  возвращаем сумму count - количество цифр в числе
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countNumber = CountNumber(number);
System.Console.WriteLine($"количество цифр в числе {number} -> {countNumber}");

