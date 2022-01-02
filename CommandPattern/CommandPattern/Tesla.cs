using System;
using CommandPattern.fx;
using CommandPattern.fx.light;
using CommandPattern.fx.speaker;

namespace CommandPattern
{
    class Tesla
    {
        private readonly Speaker _speaker = new Speaker();
        private readonly Light _light = new Light();

        private readonly Button _button = new Button();


        public void DisplayVolume()
        {
            Console.WriteLine($"The volume of the speaker is {_speaker.Volume}.");
        }

        public void DisplayLightStatus()
        {
            if (_light.LightOn)
                Console.WriteLine($"The light is on.");
            else
                Console.WriteLine($"The light is off.");
        }

        public void VolumeDown()
        {
            _button.OnClick(new TurnDownVolumeCommand(_speaker));
        }

        public void VolumeUp()
        {
            _button.OnClick(new TurnUpVolumeCommand(_speaker));
        }

        public void LightOn()
        {
            _button.OnClick(new TurnOnLightCommand(_light));
        }

        public void LightOff()
        {
            _button.OnClick(new TurnOffLightCommand(_light));
        }
    }
}