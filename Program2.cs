using System;

class Demo
{
    
    private static int counter;

    
    static Demo()
    {
        Console.WriteLine("Static constructor called.");
        counter = 100; 
    }

    
    public Demo()
    {
        Console.WriteLine("Instance constructor called.");
    }

    
    public static void ShowCounter()
    {
        Console.WriteLine($"Static counter value: {counter}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Program started.");
        
    
        Demo.ShowCounter();

       
        Demo obj1 = new Demo();
        Demo obj2 = new Demo();

        Console.WriteLine("Program ended.");
    }
}
