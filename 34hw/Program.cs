// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] startArray = GetArray(5, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных элементов в массиве = {EvenCount(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int EvenCount(int[] array)
{
    int count = 0;
    foreach (int i in array) 
    {
        if (i % 2 == 0) count++;
    }
    return count;
}

//(Foreach пометка для себя. Это для итерации по элементам массива или любой перечислимой коллекции.
//Для одномерных массивов оператор foreach обрабатывает элементы в порядке возрастания индекса, начиная с индекса 0 и заканчивая индексом Length - 1:)