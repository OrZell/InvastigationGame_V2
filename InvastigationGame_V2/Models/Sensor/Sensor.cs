using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvastigationGame_V2.Models.Sensor
{
    public class Sensor
    {
        public string Type;
        public bool Active;

        public Sensor(string type)
        {
            this.Type = type;
        }

        public virtual void Activate()
        {
            this.Active = false;
        }
    }
}
