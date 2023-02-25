using DP.ServiceLocator.StaticVersion;

//static version
static void Main(string[] args)
{
    Client client = new()
    {
        serviceA = ServiceLocator.Instance.GetIServiceA(),
        serviceB = ServiceLocator.Instance.GetIServiceB()
    };
    client.DoWork();

    Console.ReadLine();
}
