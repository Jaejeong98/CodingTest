class n_2884
{
    static void Main(string[] args)
    {
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        num[1] -= 45;
        if (num[1] < 0)
        {
            num[1] += 60;
            num[0]--;
            if (num[0] < 0)
                num[0] += 24;
        }
        Console.WriteLine(num[0] + " " + num[1]);
    }
}