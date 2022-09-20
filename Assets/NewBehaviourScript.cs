using System.Collections.Generic;
using UnityEngine;
public class Fish : Animal
{

}


public class Animal
{
    public virtual string RoarString { get; } = "";

    public int Paws { get; }

    public int Teeth { get; }

    public virtual void Roar()
    {
        Debug.Log("Generic roar");
    }
}

public class Cat : Animal
{
    public override string RoarString => "Miaou";

    public override void Roar()
    {
        base.Roar();
        Debug.Log("Miaou");
    }
}

public class Dog : Animal
{

}

public class Human : Animal
{

}