class n_2525
{
    static void Main(string[] args)
    {
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int c = int.Parse(Console.ReadLine());
        int tmp = num[1] + c % 60;
        num[1] = tmp % 60;
        num[0] += tmp / 60 + c / 60;
        Console.WriteLine(num[0] - (num[0] >= 24 ? 24 : 0) + " " + num[1]);
    }
}