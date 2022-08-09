class n_9498
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string score = "";
        if (n >= 90)
            score = "A";
        else if (n >= 80)
            score = "B";
        else if (n >= 70)
            score = "C";
        else if (n >= 60)
            score = "D";
        else
            score = "F";
        Console.WriteLine(score);
    }
}