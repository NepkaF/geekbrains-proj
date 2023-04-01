internal class Program
{
    private static void Main(string[] args)
    {
        string[] a;
        string[] b;
        Console.WriteLine("Введите количество строк");
        int n = Convert.ToInt32(Console.ReadLine());
        a = new string[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = Console.ReadLine();
        }
        b = new string[n];
        for (int i = 0; i < n; i++)
        {
            if (a[i].Length <= 3)
            {
                b[b.Length+1] = a[i];
            }
        }
        Console.WriteLine(b);
    }
}