namespace MatchingBrackets;
class Program
{
    static void Main(string[] args)
    {
        BracketsService bracketsService = new BracketsService();
        Console.WriteLine(bracketsService.CheckMatchingBrackets("{abc...xyz}"));
    }

    
}

