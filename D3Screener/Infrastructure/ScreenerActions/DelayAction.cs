namespace D3Screener.Infrastructure.ScreenerActions
{
    public class DelayAction : IScreenerAction
    {
        private int _delay;
        public DelayAction(int delay) 
        {
            _delay = delay;
        }

        public void Execute()
        {
            Task.Delay(_delay).Wait();
        }
    }
}
