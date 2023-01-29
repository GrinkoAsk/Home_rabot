// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumberByUser(string text)                      // Получили число от пользователя
{
    Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumbers(int countByUser)                     // Разбили по разрядам , переведя в строку
{
  int result = 0;

    while (countByUser > 0)
    {
      result += countByUser % 10;
      countByUser /= 10;
    }
return result;
}

int countByUser = GetNumberByUser("Введите число, если хочешь узнать сумму его цифр");
int sum = SumOfNumbers(countByUser);
Console.WriteLine(sum);
