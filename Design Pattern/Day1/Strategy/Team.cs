using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Team
    {
        TeamStrategy teamStrategy;
        public void SetStrategy(TeamStrategy s)
        {
            this.teamStrategy = s;
        }
        public void PlayGame()
        {
            teamStrategy.Play();

        }
    }
}
