using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvastigationGame_V2.Models.Agent
{
    public class FullAttackableAgent : AttackableAgent
    {
        public int FullAttackCounter;
        public int MaxFullAttackCounter;

        public FullAttackableAgent(string type, int capacity, int maxAttackCounter, int attacks, int maxFullAttackCounter) : base(type, capacity, maxAttackCounter, attacks)
        {
            this.FullAttackCounter = 0;
            this.MaxFullAttackCounter = maxFullAttackCounter;
        }
    }
}
