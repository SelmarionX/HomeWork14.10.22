// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayPositiveRandomNumbers(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);
int count = 0;

for (int x = 0; x < numbers.Length; x++) // проверка на чётность
    if (numbers[x] % 2 == 0)
        count++;

Console.WriteLine($"всего {numbers.Length} числа, {count} из них чётные");

void FillArrayPositiveRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000); //заполняем трехзначными цифрами
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}