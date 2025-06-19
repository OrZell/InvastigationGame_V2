namespace InvastigationGame_V2.Models.Sensor
{
    public class SignalSensor : Sensor
    {
        public bool Used;

        public SignalSensor() : base("signal")
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
