using System;
using System.Collections.Generic;
using Module_2_Review;


public class Program
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
        

    }
}