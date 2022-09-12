// Показать натуральные числа от M до N, N и M заданы
string NumbersRec (int M, int N)
{
    if(M<=N) return $"{M}" + NumbersRec (M+1, N);
    else return String.Empty;
}
Console.WriteLine(NumbersRec (1,12));
