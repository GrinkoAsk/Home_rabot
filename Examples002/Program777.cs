//Задача 777;
using static Library;

// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
int n = 8;
int[] arr = новый int[n];
Случайный ранд = новый случайный();
для (int i = 0; Я < обр. Длина; я++)
{
    arr[i] = rand. Далее(0,2);
}
Console.WriteLine(строка. Join(", ", arr));
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное
int main(void)
{
    char q;
    int res = 0;
    while(scanf("%c", &q)==1)
    {
        if (q != '0' && q != '1')
        {
            if (q == '\n') break; // Конец ввода
        }
        res = res*2+(q-'0');
    }
    printf("%i\n", res);
// 1. Ввод N
// int <- (string)

// 2. Создание массива
// int[] <- (int)

// 3. Заполнение массива 0 и 1
// void <- (int[])

// 4. Печать массива
// string <- (int[])

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])

// 6. 10110100 >> 180
// string <- (int[] , int)
string GoodPrint(int[] bin, int dec)
{
return $"{String.Join("", bin)} >> {dec}";
}

Console.WriteLine(GoodPrint(new int[] { 1, 0, 1, 1, 1, 1, 0 }, 56));

//ДОПОЛНИТЕЛЬНАЯ ПОЛНЫЙ ЦИКЛ РЕШЕНИЯ С РАЗБИВКОЙ НА МЕТОДЫ КАК В ПРЕДЫДУЩЕЙ ЗАДАЧЕ