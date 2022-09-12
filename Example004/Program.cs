// Найти сумму цифр числа
int SummNumbers(int N)
{
    if (N > 1) return N % 10 + SummNumbers(N / 10);
    else return 0;
}
Console.WriteLine(SummNumbers(123));
