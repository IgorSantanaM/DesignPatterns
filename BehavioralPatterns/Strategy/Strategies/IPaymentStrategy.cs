namespace StrategyPattern.Strategies
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
