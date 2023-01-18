//1
#include <iostream>
#include <vector>

int main()
{
    std::vector<int> Vect;
    int Num;

    while (std::cin >> Num) {
        Vect.push_back(Num);

        for (decltype(Vect.size()) A = 0, B = Vect.size() -1 ; A != B; ++A, --B) {
            std::cout << Vect[A] + Vect[B] << std::endl;
        }
    }

    return 0;
}

//2
uses crt;
const nmax=100;
var a:array[1..nmax] of integer;
    n,i,j,k,mn,p,i1,i2:integer;
begin
clrscr;
randomize;
repeat
write('Размер массива от 2 до ',nmax,' n=');
readln(n);
until n in [2..nmax];
writeln('Исходный массив:');
for i:=1 to n do
 begin
  a[i]:=1+random(50);
  write(a[i]:4);
 end;
writeln;
mn:=81;{произвведение последних цифр}
k:=0;
for i:=1 to n-1 do
for j:=i+1 to n do
if(a[i]<>a[j])and((a[i]mod 10)*(a[j] mod 10)<mn) then
 begin
  k:=1;
  mn:=(a[i]mod 10)*(a[j] mod 10);
  i1:=a[i];
  i2:=a[j];
  p:=a[i]*a[j];
 end;
if k=0 then write('Все элементы одмнаковые')
else
 begin
  writeln('Произведение пары различных элементов,');
  writeln('произведение последних цифр у которых минимальное=',p);
  writeln('Это числа ',i1,' и ',i2,' произведение последних цифр=',mn);
 end;
readln
end.


#include <iostream>
#include <vector>
#include <numeric>

using namespace std;

int pAdd (int x, int y) {
  if (y > 0)
    return x+y;
  return x;
}

int mAdd (int x, int y) {
  if (y < 0)
    return x+y;
  return x;
}

int main() {
 /*
 .. получаем N если надо
 */
 vector<int> A(N);
 /*
  .. заполняем своими данными
 */
 int sum1 = accumulate(A.begin(), A.end(), 0, pAdd);  
 int sum2 = accumulate(A.begin(), A.end(), 0, mAdd);  
 float div = (float)sum1 / sum2;
 cout<<div;
}

Pyton
Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# Пример:

# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

from random import randint


number = int(input('Введите размер списка '))
list = []
list2 = []

for i in range(number):
    list.append(randint(0, 9))

for i in range(len(list)):
    while i < len(list)/2 and number > len(list)/2:
        number = number - 1
        a = list[i] * list[number]
        list2.append(a)
        i += 1

print(list)
print(list2)

