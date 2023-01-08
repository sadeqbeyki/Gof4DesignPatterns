
using DesignPatterns.Adapter.Adapters;

//step 3
//IPrinter printer = new FilePrinter();

//Adapter v2 Step 4
//IPrinter printer = new InheritanceAdapter();

//Adapter Step 2
IPrinter printer = new ObjectAdapter();

Console.WriteLine("Type Something ... \n");
var textForPrint = Console.ReadLine(); 
printer.Print(textForPrint);


 