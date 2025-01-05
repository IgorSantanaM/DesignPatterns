
Singleton singleton1 = Singleton.Instance;
Singleton singleton2 = Singleton.Instance;

sealed class Singleton 
{
    private static Lazy<Singleton> _lazyInstance = new(() => new());

    public static Singleton Instance => _lazyInstance.Value;

    private Singleton()
    {
        Console.WriteLine("Creating the instance.");
    }
}
