using DP.Creational.Prototype.ExampleA;
using DP.Creational.Prototype.ExampleB;

public class Program
{
    static void Main(string[] args)
    {

        #region Example A
        //prototype way2 and fix: ICloneable step 4
        LargeObject largeObject2 = new LargeObject();
        var instance4 = largeObject2.Clone();
        instance4.Count++;
        instance4.InnerClass.Count++;
        var instance5 = largeObject2.Clone();
        instance5.Count++;
        instance5.InnerClass.Count++;
        var instance6 = largeObject2.Clone();
        instance6.Count++;
        instance6.InnerClass.Count++;

        //prototype way1: ICloneable step 2
        LargeObject largeObject = new LargeObject();
        var instance1 = largeObject.Clone();
        var instance2 = largeObject.Clone();
        var instance3 = largeObject.Clone();
        #endregion

        #region Example B

        Person p1 = new Person();
        p1.Age = 42;
        p1.BirthDate = Convert.ToDateTime("1977-01-01");
        p1.Name = "Jack Daniels";
        p1.IdInfo = new IdInfo(666);

        // Perform a shallow copy of p1 and assign it to p2.
        Person p2 = p1.ShallowCopy();
        // Make a deep copy of p1 and assign it to p3.
        Person p3 = p1.DeepCopy();

        // Display values of p1, p2 and p3.
        Console.WriteLine("Original values of p1, p2, p3:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values:");
        DisplayValues(p2);
        Console.WriteLine("   p3 instance values:");
        DisplayValues(p3);

        // Change the value of p1 properties and display the values of p1,
        // p2 and p3.
        p1.Age = 32;
        p1.BirthDate = Convert.ToDateTime("1900-01-01");
        p1.Name = "Frank";
        p1.IdInfo.IdNumber = 7878;
        Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
        Console.WriteLine("   p1 instance values: ");
        DisplayValues(p1);
        Console.WriteLine("   p2 instance values (reference values have changed):");
        DisplayValues(p2);
        Console.WriteLine("   p3 instance values (everything was kept the same):");
        DisplayValues(p3);
    }

    public static void DisplayValues(Person p)
    {
        Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
            p.Name, p.Age, p.BirthDate);
        Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
    }
    #endregion

}









