using Decorator;

internal class Program
{
    private static void Main(string[] args)
    {
        Player p = new FieldPlayer();
        PlayerRole forward = new Forward();
        forward.AssignPlayer(p);

        forward.PassBall();
        ((Forward)forward).ShootGoal();

        p = new GoalKeeper();
        PlayerRole mid = new MidFilder();
        mid.AssignPlayer(p);
        mid.PassBall();
        ((MidFilder)mid).Dribble();

        p = new FieldPlayer();
        PlayerRole def = new Defiender();
        def.AssignPlayer(p);
        def.PassBall();
        ((Defiender)def).Defend();



    }
}