using Strategy;

internal class Program
{
    private static void Main(string[] args)
    {
        Team Team1 = new();
        Team1.SetStrategy(new Attack());
        Team1.PlayGame();
        Team1.SetStrategy(new Defined());
        Team1.PlayGame();
    }
}