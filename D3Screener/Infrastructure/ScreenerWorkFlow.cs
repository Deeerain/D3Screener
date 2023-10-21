using D3Screener.Infrastructure.ScreenerActions;

namespace D3Screener.Infrastructure
{
    public class ScreenerWorkFlow : IScreenerWorkFlow
    {
        private readonly IScreenerAction[] _actions;

        public ScreenerWorkFlow(params IScreenerAction[] actions)
        {
            _actions = actions;
        }

        public void Run(int count, int delay = 0)
        {
            Task.Delay(delay).Wait();

            for (int i = 0; i < count; i++)
                foreach (var action in _actions)
                    action.Execute();
        }
    }
}
