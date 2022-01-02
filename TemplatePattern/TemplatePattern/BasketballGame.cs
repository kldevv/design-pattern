using System;

namespace TemplatePattern
{
    class BasketballGame : Game
    {
        protected override void GamePlay()
        {
            Console.WriteLine("Play a Basketball game.");
        }
    }
}