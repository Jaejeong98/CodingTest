class n_2480
{
    static void Main(string[] args)
    {
        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(num);
        int result = 0;
        if (num[0] == num[2])
            result = 10000 + num[0] * 1000;
        else if (num[0] != num[1] && num[1] != num[2])
            result = num[2] * 100;
        else
        {
            if (num[0] == num[1])
                result = num[0] * 100 + 1000;
            else
                result = num[1] * 100 + 1000;
        }
        Console.Write(result);
    }
}