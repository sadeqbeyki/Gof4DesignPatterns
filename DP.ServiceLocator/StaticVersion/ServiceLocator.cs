namespace DP.ServiceLocator.StaticVersion;

internal class ServiceLocator
{
    private static ServiceLocator locator = null;

    public static ServiceLocator Instance
    {
        get
        {
            // ServiceLocator itself is a Singleton
            if (locator == null)
            {
                locator = new ServiceLocator();
            }
            return locator;
        }
    }

    private ServiceLocator()
    {
    }

    private IServiceA serviceA = null;
    private IServiceB serviceB = null;

    public IServiceA GetIServiceA()
    {
        //we will make ServiceA a singleton
        //for this example, but does not need
        //to be in a general case
        if (serviceA == null)
        {
            serviceA = new ServiceA();
        }
        return serviceA;
    }

    public IServiceB GetIServiceB()
    {
        //we will make ServiceB a singleton
        //for this example, but does not need
        //to be in a general case
        if (serviceB == null)
        {
            serviceB = new ServiceB();
        }

        
        return serviceB;
    }
}


