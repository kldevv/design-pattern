using System;
using System.Collections.Generic;

namespace CommandPattern.fx.speaker
{
    class Speaker
    {
        public int Volume { get; private set; }

        public Speaker()
        {
            Volume = 0;
        }
        
        public void TurnUpVolume()
        {
            Console.WriteLine("Volume turning up by 1.");
            Volume += 1;
        }

        public void TurnDownVolume()
        {
            Console.WriteLine("Volume turning down by 1.");
            Volume = Math.Max(0, Volume - 1);            
        }
    }
}