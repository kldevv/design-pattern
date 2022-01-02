using System;

namespace CommandPattern.fx
{
    class Button
    {
        public void OnClick(ICommand command)
        {
            Console.WriteLine("The button is clicked.");
            command.Execute();
        }
    }
}