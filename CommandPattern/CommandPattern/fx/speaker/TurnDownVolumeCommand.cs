namespace CommandPattern.fx.speaker
{
    class TurnDownVolumeCommand : ICommand
    {
        private readonly Speaker _speaker;

        public TurnDownVolumeCommand(Speaker speaker)
        {
            _speaker = speaker;
        }
        public void Execute()
        {
            _speaker.TurnDownVolume();
        }
    }
}