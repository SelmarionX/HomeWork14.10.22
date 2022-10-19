// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

var array = new decimal[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Введите {0} число из 5  : ", i + 1);
    array[i] = Convert.ToDecimal(Console.ReadLine());
}

var max = array[0];
var min = array[0];
for (int i = 1; i < 5; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
