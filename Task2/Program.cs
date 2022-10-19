// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);
int sum = 0;

for (int x = 1; x < numbers.Length; x += 2) //Начинаем с 2-го числа (x=1) - заканчиваем предпоследним , проходим через одного x+=2
    sum = sum + numbers[x];

Console.WriteLine($"всего {numbers.Length} числа, сумма элементов на нечётных позициях = {sum}, (!!!отчёт идёт с 0!!!)");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100); // генирим рандомные цифры от отрицательных, до положительных
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ "); // открывает [ скобку для отображения массива в принте
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]"); // закрываем ] скобку для отображения массива в принте
    Console.WriteLine();
}


