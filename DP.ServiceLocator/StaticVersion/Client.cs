namespace DP.ServiceLocator.StaticVersion;

internal class Client
{
    public IServiceA serviceA = null;
    public IServiceB serviceB = null;

    public void DoWork()
    {
        serviceA?.UsefulMethod();
        serviceB?.UsefulMethod();
    }
}


