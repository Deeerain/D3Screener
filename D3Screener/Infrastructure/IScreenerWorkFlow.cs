namespace D3Screener.Infrastructure
{
    public interface IScreenerWorkFlow
    {
        void Run(int count, int delay = 0);
    }
}