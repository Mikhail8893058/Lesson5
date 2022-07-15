// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите размер массива:");
int ASize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[ASize];
FillArrayRandomNumbers(array);
Console.WriteLine("Вот наш массив: ");
PrintArray(array);
int count = 0;


for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine($"всего {array.Length} чисел, колличество четных чисел = {count} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}