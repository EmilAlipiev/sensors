using System;
using Android.Hardware;


namespace Plugin.Sensors
{
    public class BarometerImpl : AbstractSensor<double>, IBarometer
    {
        public BarometerImpl() : base(SensorType.Pressure)
        {
        }


        protected override double ToReading(SensorEvent e)
        {
            return e.Values[0];
        }
    }
}