using DesignPatterns.Prototype;

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


Console.WriteLine("Hello, World!");
