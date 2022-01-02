using System;

namespace CommandPattern.fx.light
{
    class Light
    {
        public bool LightOn { get; private set; }

        public Light()
        {
            LightOn = false;
        }
        public void TurnOnLight()
        {
            Console.WriteLine("Turning on light.");
            LightOn = true;
        }

        public void TurnOffLight()
        {
            Console.WriteLine("Turning off light.");
            LightOn = false;
        }
    }
}