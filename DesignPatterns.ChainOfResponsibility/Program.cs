using DesignPatterns.ChainOfResponsibility.ExampleA;
using DesignPatterns.ChainOfResponsibility.ExampleB;

#region Example A
Customer from = new Customer
{
    AccountValue = 1000,
    Active = true,
    MaxDateValue = 100,
    Password = "1234"
};
Customer to = new Customer
{
    AccountValue = 20000,
    Active = true,
    MaxDateValue = 2000,
    Password = "1234"
};

// به جای شرط های پشت سرهم با این نوع کلاس چینی میتوانیم هر طور که میخواهیم پول را انتقال دهیم
var transfer1 = new CheckPassword(new IsActiveUser(new CheckBalance(new TransferFinal(null))));
var transfer2 = new CheckPassword(new CheckBalance(new IsActiveUser(new TransferFinal(null))));
var transfer3 = new CheckPassword(new CheckBalance(new TransferFinal(null)));

var result = transfer1.Execute(new RequestContext
{
    From = from,
    To = to,
    Password = "1234",
    Value = 1500
});

Console.WriteLine(result.Message);
Console.ReadLine();
#endregion

#region Example B
// The other part of the client code constructs the actual chain.
var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

// The client should be able to send a request to any handler, not
// just the first one in the chain.
Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
Client.ClientCode(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
Client.ClientCode(squirrel);
#endregion

