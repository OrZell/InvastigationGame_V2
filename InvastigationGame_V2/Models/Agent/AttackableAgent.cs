using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvastigationGame_V2.Models.Agent
{
    public class AttackableAgent : Agent
    {
        public int AttackCounter;
        public int MaxAttackCounter;
        public int Attacks;

        public AttackableAgent(string type, int capacity, int maxAttackCounter, int attacks) : base(type, capacity)
        {
            this.AttackCounter = 0;
            this.MaxAttackCounter = maxAttackCounter;
            this.Attacks = attacks;
        }
    }
}
