using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PlayerRole
    {

        Player player;
        public void PassBall()
        {
            Console.WriteLine("Welcom in PlayerRole Class : Pass Ball Function");
        }
      public  void AssignPlayer(Player p)
        {
           this.player = p;

        }
    }
}
