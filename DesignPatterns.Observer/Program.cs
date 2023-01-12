//step 6

using DesignPatterns.Observer;

Person person = new Person
{
    FullName = "arvand hormoz",
};
Person person2 = new Person
{
    FullName = "behnam sohrabi",
};

Departman forosh = new Departman
{
    DepId = 1,
};

Departman ersal = new Departman
{
    DepId = 2
};

Inventory subject = new Inventory();
subject.Registration(person);
subject.Registration(person2);
subject.Registration(forosh);
subject.Registration(ersal);

subject.Product = 2;
Console.WriteLine("________________________");

subject.Product = 3;
Console.WriteLine("________________________");

subject.Remove(person);
Console.WriteLine("remove");
Console.WriteLine("________________________");

subject.Product = 2;
Console.WriteLine("________________________");

Console.Read();

