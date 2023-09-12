using System;

public class Student
{
    // private fields
    private string name;
    private int age;
    private string studentId;

    // Constructor 
    public Student(string name, int age, string studentId)
    {
        this.name = name;
        this.age = age;
        this.studentId = studentId;
    }

    // Name property - only read
    public string Name
    {
        get { return name; }
    }

    // Age özelliği (property) - only read
    public int Age
    {
        get { return age; }
    }

    // StudentId özelliği (property) - only read
    public string StudentId
    {
        get { return studentId; }
    }

    // Write information
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentId}");
    }
}