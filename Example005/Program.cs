// Написать программу вычисления функции Аккермана

int FunctionAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAkk(m - 1, 1);
    else return FunctionAkk(m - 1, FunctionAkk(m, n - 1));
}
Console.WriteLine(FunctionAkk(3, 5));
