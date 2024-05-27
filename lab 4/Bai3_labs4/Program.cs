using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Bảo Trâm", 15),
            new Student("Quốc Trung", 18),
            new Student("Huyền Trang", 20),
            new Student("Gia lâm", 22),
            new Student("Vân Anh", 13)
        };

        var querySyntaxResult = from student in students
                                where student.Age > 12 && student.Age < 20
                                select student;

        Console.WriteLine("Các student có Age > 12 và Age < 20 (Query Syntax):");
        foreach (var student in querySyntaxResult)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        var methodSyntaxResult = students.Where(student => student.Age > 12 && student.Age < 20);

        Console.WriteLine("\nCác student có Age > 12 và Age < 20 (Method Syntax):");
        foreach (var student in methodSyntaxResult)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}
