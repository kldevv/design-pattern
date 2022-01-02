using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tesla = new Tesla();
            
            tesla.DisplayVolume();
            tesla.VolumeUp();
            tesla.DisplayVolume();
            tesla.VolumeDown();
            tesla.DisplayVolume();
            
            tesla.DisplayLightStatus();
            tesla.LightOn();
            tesla.DisplayLightStatus();
            tesla.LightOff();
            tesla.DisplayLightStatus();
        }
    }
}