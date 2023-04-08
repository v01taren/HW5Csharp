// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] startArrayDouble = GetArrayDouble(6, 0, 20);
Console.WriteLine(String.Join(" ", startArrayDouble));
Console.WriteLine($"Разница = {GetDifference(startArrayDouble)}");

double[] GetArrayDouble(int size, int minValue, int maxValue)
{
    double[] result = new double[size];

    var randon = new Random();

    for (int i = 0; i < size; i++)
    {
        result[i] = randon.Next(minValue, maxValue + 1) + randon.NextDouble(); //число с плавающей запятой
    }
    return result;
}

double GetDifference(double[] array)
{
    double min = array [0];
    double max = array[0];
    foreach (int i in array)
    {
        if (min > i) min = i;
        if (max < i) max = i;
    }
    return max - min;
}
