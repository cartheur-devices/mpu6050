using System;

namespace Cartheur.Devices
{
    public class MpuSensorEventArgs : EventArgs
    {
        public byte Status { get; set; }
        public float SamplePeriod { get; set; }
        public MpuSensorValue [] Values { get; set; }
    }
}