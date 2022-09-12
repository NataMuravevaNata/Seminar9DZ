// Написать программу возведения числа А в целую степень B

int PowerRec (int A, int B);
{
    if (B == 0) return 1;
    else return PowerRec (A, B-1)*A;
}
Console.WriteLine(PowerRec(2,8));

