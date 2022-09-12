// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
/*
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) return;
string PrintNumber (int start, int end)
{
    // базовый случай - выход из рекурсии
    if (start == end) return start.ToString();
    // рекурсивный  случай
    return (start + ",  " + PrintNumber(start + 1, end));
}
Console.WriteLine($"Числа от 1 до {N} это {PrintNumber(M, N)}");
*/



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) return; 
int SumNumber (int start, int end)
{
    // базовый случай - выход из рекурсии
    if (start == end) return start;
    // рекурсивный  случай
    
    return (start + SumNumber(start + 1, end));
}
Console.WriteLine($"Сумма чисел от  {M} до {N} это {SumNumber(M, N)}");
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе чмсло: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ack(m - 1, 1);
    else if (m > 0 && n > 0) return Ack(m - 1, Ack(m, n - 1));
    else
    {
        Console.WriteLine("Функция только для неотрицательных чисел");
        return -1;
    }
}
int ackermann = Ack(m, n);
Console.WriteLine($" Значение функции Аккермана - {ackermann}");

