// Показать натуральные числа от N до 1, N задано
string result = string.Empty;
string Number(int n)
{
    result += n + " ";
    if (n > 1) Number(n - 1);
    return result;
}
Console.WriteLine(Number(10));
