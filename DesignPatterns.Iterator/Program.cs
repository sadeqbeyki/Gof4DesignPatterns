
using DesignPatterns.Iterator;

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

Console.WriteLine("Hello, World!");
