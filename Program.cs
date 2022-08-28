/* Напишите программу, которая на вход принимает число 
и выдает его квадрат (число умноженное на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

//Console.Write("Введите число: ");

//int number = Convert.ToInt32(Console.ReadLine());
//int square = number * number;
//Console.WriteLine(square);


 //Напишите программу, которая на вход принимает два числа 
//и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = 3 -> да
//a = -3, b = 9 -> нет

/*
Console.Write("Веедите число №1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber) //f = 25, s = 5
{
    Console.WriteLine(firstNumber + " является квадратом от " + secondNumber);
    // Конкатенация - процесс сложения строк: "1" + "1" = "11"
}
// "!=" - проверка на неравенство 5 != 5 - False
// "==" - равенство. 5 == 5 - True
else // if (firstNumber != secondNumber * secondNumber)
{
    Console.WriteLine(firstNumber + " НЕ является квадратом от " + secondNumber);
}

*/

/*int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1)
{
    Console.WriteLine("Понедельник");
}

if (dayNumber == 2)
{
    Console.WriteLine("Вторник");
}

if (dayNumber == 3)
{
    Console.WriteLine("Среда");
}

if (dayNumber == 4)
{
    Console.WriteLine("Четверг");
}

if (dayNumber == 5)
{
    Console.WriteLine("Пятница");
}

if (dayNumber == 6)
{
    Console.WriteLine("Суббота");
}
if (dayNumber == 7)
{
    Console.WriteLine("Воскресенье");
}
*/

// Напишите программу, которая навход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

/*Console.Write("Введите число N: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number*=(-1);

// -N = N*(-1)
// [-N ; N] -> [negativeNumber; number]
int negativeNumber = number * (-1);
while (negativeNumber <= number) // пока справедливо условие
{
    Console.WriteLine(negativeNumber);
    negativeNumber++;
    // negativeNumber+=1
}

}
*/

//ДОМАШНЕЕ ЗАДАНИЕ

/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* Console.Write("Введите число №1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение ", a, b);
}
else
{
    Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение ", b, a);
} */

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
 из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

 /* Console.Write("Введите число №1: ");
 int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
 int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №3: ");
 int c = Convert.ToInt32(Console.ReadLine());
 if (a > b)
 {
    Console.WriteLine("{0} - максимальное число", a, b, c);
 }
 else 
 {
     Console.WriteLine("{0} - максимальное число", c, b, a);
 }
 if (b > c)
 {
     Console.WriteLine("{0} - максимальное число", c, a, b);
 }
*/


 /* Задача 6. Напишите программу, которая на вход принимает число и выдаёт, 
 является ли число чётным (делится ли оно на два без остатка).

 Console.Write("Введите число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 if (n % 2 == 0)
 {
    Console.WriteLine("Чётное", n);
 }  
else
{
    Console.WriteLine("Нечётное", n);
} */