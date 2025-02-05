using System;

class Student
{
    private string name;
    private int age;

    
    public Student()
    {
        Console.WriteLine("This is a parameterless constructor.");
        name = "Unknown";
        age = 0;
    }

   
    public Student(string studentName, int studentAge)
    {
        Console.WriteLine("This is a parameterized constructor.");
        name = studentName;
        age = studentAge;
    }

    public Student(string studentName = "Default Name", int studentAge = 18)
    {
        Console.WriteLine("This is a constructor with default arguments.");
        name = studentName;
        age = studentAge;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    static void Main(string[] args)
    {
       
        Student s1 = new Student(); 
        Student s2 = new Student("Alice", 21); 
        Student s3 = new Student("Bob"); 

        
        s1.Display();
        s2.Display();
        s3.Display();
    }
}
