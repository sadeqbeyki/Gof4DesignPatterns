
// step 5
using DesignPatterns.Proxy;
//وقتی نمیخوایم از کش استقاده کنیم فالس در غیر این صورت ترووو
var cacheSetting = false;

IPersonRepository personRepository = 
    cacheSetting? new CachePersonRepository(new InMemoryPersonRepository()) :
    new InMemoryPersonRepository();

var searchResult = personRepository.GetAll();
foreach (var item in searchResult)
{
    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
}
Console.WriteLine("Hello, World!");
