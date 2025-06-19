using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvastigationGame_V2.Models.Agent
{
    public class Agent
    {
        public string Type;
        public int Capacity;

        public Agent(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
        }
    }
}
