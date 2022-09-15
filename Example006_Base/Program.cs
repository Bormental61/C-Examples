internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int c = 6;
        int d = 8;
        int e = 4;

        int max = a;

        if (a > max) max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;
        if (e > max) max = e;

        System.Console.WriteLine("Find Max");
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.Write("Max = ");
        System.Console.WriteLine(max);
    }
}