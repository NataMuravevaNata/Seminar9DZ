// Найти сумму элементов от M до N, N и M заданы
int temp = 0;
int SummNumber(int m, int n)
{
    if (m < n) SummNumber(m, n - 1);
    temp += n;
    return temp;
}
Console.WriteLine(SummNumber(1, 100));
