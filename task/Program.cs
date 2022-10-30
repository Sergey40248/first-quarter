internal class Program
{
    private static void Main(string[] args)
    {
        string[] newArr = { "gggd", " ", "7", "hhh", "hfhfhfh" };
        var resultArr = newArr.Where(x => x.Length < 4).ToArray();
        for (int i = 0; i < resultArr.Length; i++)
            Console.Write(@"""{1},"" ", i, resultArr[i]);
    }
}