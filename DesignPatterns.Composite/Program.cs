using DesignPatterns.Composite;

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



