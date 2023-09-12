﻿class Program
{
    static void Main(string[] args)
    {
        // Student sınıfından bir nesne oluşturalım
        Student student = new Student("Alice Johnson", 22, "123456");

        // Direct access to private fields of the Student class is denied,
        // However, we can access this information using the features.
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Student ID: {student.StudentId}");

        // Bilgileri yazdırmak için metodu çağırabiliriz.
        student.PrintInfo();
    }
}