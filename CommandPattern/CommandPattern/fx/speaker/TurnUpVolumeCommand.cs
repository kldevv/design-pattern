namespace CommandPattern.fx.speaker
{
    class TurnUpVolumeCommand : ICommand
    {
        private readonly Speaker _speaker;

        public TurnUpVolumeCommand(Speaker speaker)
        {
            _speaker = speaker;
        }
        
        public void Execute()
        {
            _speaker.TurnUpVolume();
        }
    }
}