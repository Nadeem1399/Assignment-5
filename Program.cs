using System;

// Interface for movement
public interface IMove
{
    string Move();
}

// Animal class
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual string MakeSound()
    {
        return "Generic animal sound";
    }
}

// Dog class derived from Animal
public class Dog : Animal, IMove
{
    public override string MakeSound()
    {
        return "Woof";
    }

    public string Move()
    {
        return "Dog walks";
    }
}

// Cat class derived from Animal
public class Cat : Animal, IMove
{
    public override string MakeSound()
    {
        return "Meow";
    }

    public string Move()
    {
        return "Cat runs";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog rex = new Dog();
        rex.Name = "Rex";
        rex.Age = 5;

        Cat whiskers = new Cat();
        whiskers.Name = "Whiskers";
        whiskers.Age = 3;

        Console.WriteLine($"{rex.Name} is {rex.Age} years old, makes a {rex.MakeSound()} sound, and {rex.Move()}.");
        Console.WriteLine($"{whiskers.Name} is {whiskers.Age} years old, makes a {whiskers.MakeSound()} sound, and {whiskers.Move()}.");
    }
}

