using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Forward:PlayerRole
    {
        public void ShootGoal()
        {
            Console.WriteLine("ShootGoal in Forward Class");
        }
    }
}
