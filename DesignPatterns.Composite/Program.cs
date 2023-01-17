
using DP.Structural.Composite.ExampleA;
using DP.Structural.Composite.ExampleB;

#region Example B
Client client = new Client();

// This way the client code can support the simple leaf
// components...
Leaf leaf = new Leaf();
Console.WriteLine("Client: I get a simple component:");
client.ClientCode(leaf);

// ...as well as the complex composites.
Composite tree = new Composite();
Composite branch1 = new Composite();
branch1.Add(new Leaf());
branch1.Add(new Leaf());
Composite branch2 = new Composite();
branch2.Add(new Leaf());
tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine("Client: Now I've got a composite tree:");
client.ClientCode(tree);

Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
client.ClientCode2(tree, leaf);
#endregion


#region Example A
//Composite step 4

var items = new List<INode>
{
    new Person{Name="siavash"},
    new Person{Name="sohrab"},
    new Group
    {
        Name="Developers",
        Nodes= new List<INode>
        {
            new Person{Name="behzad"},
            new Person{Name="Behnam"},
            new Group
            {
                Name="Testers",
                Nodes = new List<INode>
                {
                    new Person{Name = "Mehrzad"},
                    new Person{Name = "Behrooz"},
                    new Group
                    {
                        Name="Support",
                        Nodes=new List<INode>
                        {
                        new Person{Name="Aydin"},
                        new Person{Name="Mehraveh"}
                        }
                    }
                }
            }
        }
    }
};



int score = 13800;

int count = items.Count;

int indivisualScore = score / count;
Console.WriteLine("Just Do it : ");
foreach (var item in items)
{
    item.Score = indivisualScore;
}

Console.ReadLine();
#endregion




//step 3
//List<Person> people = new List<Person>
//{
//    new Person{Name="siavash"},
//    new Person{Name="sohrab"},
//};

//List<Group> groups = new List<Group>
//{
//    new Group
//    {
//        Name="Developers",
//        People= new List<Person>
//        {
//            new Person{Name="behzad"},
//            new Person{Name="Behnam"},
//        }
//    }
//};
////مجموع امتیاز
//int score = 8000;
////مجموع اشخاص و گروه 
//int count = people.Count + groups.Count;
////به هر شخص چقدر تعلق میگیرد
//int indivisualScore = score / count;
//foreach (var item in people)
//{
//    item.Score = indivisualScore;
//}
//foreach (var item in groups)
//{
//    int groupScore = indivisualScore / item.People.Count;
//    foreach (var person in item.People)
//    {
//        person.Score = groupScore;
//    }
//}



