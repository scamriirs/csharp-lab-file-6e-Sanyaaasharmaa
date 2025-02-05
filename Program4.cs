using System;

class Student
{
    private string name;
    private int age;

   
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
   }
    public Student() : this("Default Name", 18)
    {
        Console.WriteLine("Constructor chaining using 'this'.");
    }

   
    public void ShowDetails()
    {
        Console.WriteLine($"Name: {this.name}, Age: {this.age}");
    }

   
    public void Compare(Student otherStudent)
    {
        if (this.age > otherStudent.age)
            Console.WriteLine($"{this.name} is older than {otherStudent.name}.");
        else if (this.age < otherStudent.age)
            Console.WriteLine($"{this.name} is younger than {otherStudent.name}.");
        else
            Console.WriteLine($"{this.name} and {otherStudent.name} are of the same age.");
    }

    static void Main(string[] args)
    {
        
        Student s1 = new Student("Alice", 20);
        Student s2 = new Student("Bob", 22);
        Student s3 = new Student();

        
        s1.ShowDetails();
        s2.ShowDetails();
        s3.ShowDetails();

       
        s1.Compare(s2);
    }
}
