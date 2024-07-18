using System;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }

    public Person() { }

    public Person(int id, string firstName, string lastName, string address, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Age = age;
    }

    public virtual void Print()
    {
        Console.WriteLine($"ID: {Id}, Name: {FirstName} {LastName}, Address: {Address}, Age: {Age}");
    }
}

public class Teacher : Person
{
    public double Salary { get; set; }
    public string Subjects { get; set; }

    public Teacher() { }

    public Teacher(int id, string firstName, string lastName, string address, int age, double salary, string subjects)
        : base(id, firstName, lastName, address, age)
    {
        Salary = salary;
        Subjects = subjects;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Salary: {Salary}, Subjects: {Subjects}");
    }
}

public class Student : Person
{
    public int SchoolYear { get; set; }
    public string Clas { get; set; }

    public Student() { }

    public Student(int id, string firstName, string lastName, string address, int age, int schoolYear, string clas)
        : base(id, firstName, lastName, address, age)
    {
        SchoolYear = schoolYear;
        Clas = clas;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"School Year: {SchoolYear}, Class: {Clas}");
    }
}