namespace InvastigationGame_V2.Models.Sensor
{
    public class MagnetSensor : Sensor
    {
        public bool Used;

        public MagnetSensor() : base("magnet")
        {
            this.Used = false;
        }

        public override void Activate()
        {
            this.Used = true;
            base.Activate();
        }
    }
}
