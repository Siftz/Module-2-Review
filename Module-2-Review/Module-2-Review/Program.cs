using System;
using System.Collections.Generic;
namespace Module_2_Review
{

class Program
{
    static void Main()
    {
        // create a list of students
        List<Student> students = new List<Student>();
        
        //create and instance of the student class
        Student student1 = new Student {Name = "Alice", ID = 1 };
        Student student2 = new Student {Name = "Bob", ID = 2};
        Student student3 = new Student { Name = "Logan", ID = 3 };
        Student student4 = new Student { Name = "Madison", ID = 4 };
        
        // populate the list
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);
        
        // add grades per student
        student1.AddGrade(90.5);
        student1.AddGrade(87.3, 92.1, 85.0);
        
        student2.AddGrade(76.4);
        student2.AddGrade(88.6, 84.0);
        
        student3.AddGrade(95.2, 89.7);
        student3.AddGrade(91.0);

        student4.AddGrade(80.0, 72.5, 78.3);
        student4.AddGrade(88.0);
        
        //student info section
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
            //Console.WriteLine($"Grades: "+string.Join(", ", student.Grades));
            // above code does same as the foreach below, but I like using the foreach more
            foreach (var grade in student.Grades)
            {
                Console.Write(grade + "  "); // displays each grade with a space
            }
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}"); // decimal out 2
            Console.WriteLine();
        }

    }
}
}