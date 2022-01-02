using System;

namespace TemplatePattern
{
    abstract class Game {
        // Template method here.
        public void Play()
        {
            Console.WriteLine("Initial a game play.");
            GamePlay();
            Console.WriteLine("Conclude the game.");
        }
        // Abstract primitive method here.
        protected abstract void GamePlay();
    }
}