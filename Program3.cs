using System;

class Singleton
{
   
    private static Singleton instance;

    
    private int count;


    private Singleton()
    {
        Console.WriteLine("Private Constructor Called");
        count = 100; 
    }

   
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton(); 
        }
        return instance;
    }

    
    public void Display()
    {
        Console.WriteLine($"Count: {count}");
    }
}

class Program
{
    static void Main(string[] args)
    {
   
        Singleton obj1 = Singleton.GetInstance();
        obj1.Display();

    
        Singleton obj2 = Singleton.GetInstance();
        obj2.Display();

       
        Console.WriteLine($"obj1 and obj2 are same instance: {ReferenceEquals(obj1, obj2)}");
    }
}
