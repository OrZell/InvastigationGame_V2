namespace InvastigationGame_V2.Models.Sensor
{
    public class PulseSensor : Sensor
    {
        public int BreackCounter;

        public PulseSensor() : base("pulse")
        {
            this.BreackCounter = 0;
        }

        public void Attack()
        {
            if (this.BreackCounter < 2)
            {
                this.BreackCounter++;
            }
            else
            {
                this.Activate();
                this.BreackCounter = 0;
            }
        }
    }
}
