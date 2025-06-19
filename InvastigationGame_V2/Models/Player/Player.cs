using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvastigationGame_V2.Models.Player
{
    public class Player
    {
        public string Name;
        private int _Level;
        public int Level
        {
            get { return _Level; }
            set
            {
                if (value < 5)
                {
                    _Level = value;
                }
            }
        }

        public Player(string name, int level = 1)
        {

        }

        public void IncreaseLevel()
        {
            this.Level++;
        }
    }
}
