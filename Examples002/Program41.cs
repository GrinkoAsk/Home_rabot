// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write($"Введите число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbersM = new int[m];

void EnteringNumber(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arrayNumbersM[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] arrayN)
{
    int count = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        if (arrayN[i] > 0) count += 1;
    }
    return count;
}

EnteringNumber(m);

Console.WriteLine($"Введено чисел больше '0':  {Comparison(arrayNumbersM)} ");