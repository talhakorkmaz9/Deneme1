using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int toplam = Topla(a, b);

        Console.WriteLine("Sonuç: " + toplam);
    }

    static int Topla(int x, int y)
    {
        int sonuc = x + y;
        return sonuc;
    }
}
