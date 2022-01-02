using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Game basketballGame = new BasketballGame();
            Game footballGame = new FootballGame();
            basketballGame.Play();
            footballGame.Play();
        }
    }
}