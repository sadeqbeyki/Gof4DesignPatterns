
using DesignPatterns.Adapter.Adapters;
using DesignPatterns.Adapter.ExampleA;
using DesignPatterns.Adapter.ExampleB;


#region Example A
Console.WriteLine("Type Something... ");
var text = Console.ReadLine();

//without adapter
DesignPatterns.Adapter.ExampleA.IPrinter printer = new Printer();
printer.Print(text);

//with adapter
DesignPatterns.Adapter.ExampleA.IPrinter printerAdapter = new PrintAdapter();
printerAdapter.Print(text);
#endregion 



#region Example B     

Adaptee adaptee = new();
ITarget target = new Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());

#endregion



//step 3
//IPrinter printer = new FilePrinter();

//Adapter v2 Step 4
//IPrinter printer = new InheritanceAdapter();

//Adapter Step 2
DesignPatterns.Adapter.Adapters.IPrinter printer = new ObjectAdapter();

Console.WriteLine("Type Something ... \n");
var textForPrint = Console.ReadLine();
printer.Print(textForPrint);


