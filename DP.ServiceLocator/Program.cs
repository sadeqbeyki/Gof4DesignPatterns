using DP.ServiceLocator.StaticVersion;

//static version
static void Main(string[] args)
{
    Client client = new Client();
    client.serviceA = ServiceLocator.Instance.GetIServiceA();
    client.serviceB = ServiceLocator.Instance.GetIServiceB();
    client.DoWork();

    Console.ReadLine();
}
