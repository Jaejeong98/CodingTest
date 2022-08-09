class n_2753
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 4 == 0 && n % 100 != 0 || n % 400 == 0 ? 1 : 0);
    }
}