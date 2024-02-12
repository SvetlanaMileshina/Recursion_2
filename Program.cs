//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AckermanFormula(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermanFormula(m - 1, 1);
    else
        return AckermanFormula(m - 1, AckermanFormula(m, n - 1));
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A {m},{n} => {AckermanFormula(m, n)}");


