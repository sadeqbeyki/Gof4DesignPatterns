using DesignPatterns.ChainOfResponsibility;

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
