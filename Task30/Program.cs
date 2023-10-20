// Напишите программу, которая
// 1. выводит массив из 8 элементов,
// 2. заполненный 0 и 1 в случайном порядке
// [00101110]
// 
// Способы инициализации (создания) МАССИВА.
int[] array = new int[8];  // 0 1 2 3 4 5 6 7 - индексы элементов начинаются с 0.
int[] array1 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8 };
var array4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; // var можем использовать, когда знаем тип данных 
// в правой части выражения.
var array5 = 5 / 4 + 6 - 8 / 11; //ТАК НЕЛЬЗЯ!!!

array[0] = 123;  // присвоить элементу массива с индексом 0 (первые элемент) значение 123.

// ПРИМЕР Создания МАССИВА для разных типов данных
int[] arrayInt = new int[8];
string[] arrayStr = new string[7];  //пример
bool[] arrayBool = new bool[5];  //пример
Random[] arrayRandom = new Random[8];  //пример с типом данных(классом)


for (int i = 0; i < array.Length; i++)  // цикл for - создан для работы с МАССИВАМИ(удобнее всего!)
{
    array[i] = i * i;
    Console.Write(array[i] + " ");
}

// РЕШЕНИЕ ЗАДАЧИ //

int[] RandomArray(int min, int max, int length)
{
    int[] arr = new int[length];
    var rnd = new Random();  // При таком варианте допускается использование var
    // НЕОБХОДИМО создать объект(переменную var rnd = new Random();), чтобы не создавать объекты памяти в каждой итеррации цикла!)
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int[] array8 = RandomArray(0,1,8);
Console.WriteLine();
PrintArray(array8);

