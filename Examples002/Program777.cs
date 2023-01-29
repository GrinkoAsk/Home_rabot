//Задача 777;
using static Library;
// // Напишите программу, которая выводит массив из N элементов,
// // заполненный нулями и единицами в случайном порядке.
// // Самое левое число != 0
// // Данный массив есть двоичное представление десятичного числа
// // [1,0,1,1,0,1,0,0]
// // Реализовать перевод двоичного числа в десятичное

// int GetNumberByUser(string text)                   // Считать данные от пользователя
// {
//     Console.WriteLine(text + ": ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] CreateArray(int size)                       // Создание массива
// {
//    return new int[size+1]; 
// }
 
// void FillArray(int[] collection)                  // Метод заполнения массива случайными числами от 0 до 1
// {
//     int length = collection.Length;
//     int index = 1;
//     collection[0] = 1;
//     while (index < length)
//     {
//         collection[index] = Random.Shared.Next(2); 
//         index++;
//     }
// }

// string PrintArray(int[] collection)               // Метод печати массива
// {
//     string output = String.Empty;
//     int size = collection.Length;
//     for (int i = 0; i < collection.Length; i++)
//     {
//         output = output + $"{collection[i]} ";
//     }
//     return output;
// } 

// int toDecimal(int[] collection)                   // Переводим в десятичную из двоичной
// {
// int count = collection.Length;
// int exponent = collection.Length - 1; 
// int result = 0;
// for (int i = 0; i < collection.Length; i++)
// {
//     if (collection[i] == 1)
//     {
//         result += Convert.ToInt32(Math.Pow(2, exponent));
//     }
//     exponent--;
// }
// return result;
// }

// string GoodPrint(int[] collection, int dec)       // Красиво печатаем результат
// {
//     return $"{String.Join("", collection)} >> {dec}";
// }

int countByUser = GetNumberByUser("Введите число");
int[] array = CreateArray(countByUser);
FillArray(array);                                   // Вызов метода заполнения  массива
PrintArray(array);                                  // Вызов метода печати массива
int result = toDecimal(array);                      // Кладем результат конвертации в int
string decNumber = PrintArray(array);               // Делаем строку из результата распечатки
Console.WriteLine(decNumber);            
Console.WriteLine(GoodPrint(array, result));