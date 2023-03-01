using ObserverBall;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player1 = new();
        Player player2 = new();
        Refree Refree = new();
        Football ball=new();
        ball.Attach(player1);
        ball.Attach(player2);
        ball.Attach(Refree);
        Position pos = new Position(1, 2, 3);
        ball.SetBallPOsition(pos);

    }
}