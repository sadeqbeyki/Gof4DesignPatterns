using DP.Behavioral.Iterator.ExampleA;


#region ExampleA
//Iterator Step 6

PersonCollection personCollection = new PersonCollection();
personCollection[0] = new Person
{
    FirstName = "mehrnoosh",
    LastName = "Telaei"
};
personCollection[1] = new Person
{
    FirstName = "Sepehr",
    LastName = "Firooz"
};


var enamerator = personCollection.GetEnumerator();
while (enamerator.MoveNext() != null)
{
    Console.WriteLine(enamerator.Current.FirstName);
}

//Iterator Step 9 ... 
//PersonQueue personQueue = new PersonQueue();
//var enameratorQueue = personQueue.GetEnumerator();
//while (enamerator.MoveNext() != null)
//{
//    Console.WriteLine(enameratorQueue.Current.FirstName);
//}


//step 3
//PersonCollection personCollection =new PersonCollection();
//personCollection[0] = new Person
//{
//    FirstName = "mehrnoosh",
//    LastName = "Telaei"
//};
//personCollection[1] = new Person
//{
//    FirstName = "Sepehr",
//    LastName = "Firooz"
//};

//for (int i = 0; i < personCollection.Count(); i++)
//{
//    Console.WriteLine(personCollection[i].FirstName);
//}







//List<int> intlist = new List<int>();
//int[] intArray= new int[] { 1, 2, 3 };
//Stack<int> insStack= new Stack<int>();

////پیمایش کالکشن
//var listEnum = intlist.GetEnumerator();
//var arrayEnum = intArray.GetEnumerator();
//var stackEnum = insStack.GetEnumerator();

//listEnum.MoveNext();
//arrayEnum.MoveNext();
//stackEnum.MoveNext();

#endregion


#region Example B
// The client code may or may not know about the Concrete Iterator
// or Collection classes, depending on the level of indirection you
// want to keep in your program.
var collection = new WordsCollection();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine("Straight traversal:");

foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nReverse traversal:");

collection.ReverseDirection();

foreach (var element in collection)
{
    Console.WriteLine(element);
}
#endregion