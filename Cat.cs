using System;

class Cat
{
    public string Color { get; set; }
    public int Age {get; set; }

    public Cat(string color, int age)
    {
        Color = color;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"This is a {Color} cat that is {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Cat cat1 = new Cat("Tuxedo", 3);
        cat1.Display();
    }
}