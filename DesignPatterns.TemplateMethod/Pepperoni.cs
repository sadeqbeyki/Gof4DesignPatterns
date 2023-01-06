﻿namespace DesignPatterns.TemplateMethod;

public class Pepperoni : PizzaCooker
{
    public override void PrepareBread()
    {
        //buy bread
    }

    public override void PrepareIngridients()
    {
        //buy pepperoni things
    }
}