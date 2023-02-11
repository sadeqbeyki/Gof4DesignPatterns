
using DP.Structural.Proxy.ExampleA;

#region Example A
// step 5

//وقتی نمیخوایم از کش استقاده کنیم فالس در غیر این صورت ترووو
var cacheSetting = false;

IPersonRepository personRepository =
    cacheSetting ? new CachePersonRepository(new InMemoryPersonRepository()) :
    new InMemoryPersonRepository();

var searchResult = personRepository.GetAll();
foreach (var item in searchResult)
{
    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
}
Console.WriteLine("Hello, World!");
#endregion


#region Example B
Client client = new Client();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy proxy = new Proxy(realSubject);
client.ClientCode(proxy);
#endregion
