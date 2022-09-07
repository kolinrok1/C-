int Arcane (int n, int m)
{
   if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Arcane(n - 1, 1);
    if (n > 0 && m > 0) return Arcane(n - 1, Arcane(n, m - 1));
    return Arcane(n,m);
}




Console.WriteLine("Введите число M");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n =Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Arcane(m, n));

