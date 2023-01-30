using DesignPatterns.Singleton.ExampleA;
using DesignPatterns.Singleton.ExampleB;

#region Example A

var instance =  SiteSetting.Instance;
Console.WriteLine("Hello, World!");

#endregion

#region Example B

// The client code.
Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}
#endregion
