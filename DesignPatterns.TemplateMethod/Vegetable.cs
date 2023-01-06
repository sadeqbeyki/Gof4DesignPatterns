﻿namespace DesignPatterns.TemplateMethod;

public class Vegetable : PizzaCooker
{
    public override void PrepareBread()
    {
        //buy bread
    }

    public override void PrepareIngridients()
    {
        //buy Vegetable
    }
}
