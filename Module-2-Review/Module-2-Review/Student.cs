using System;
using System.Collections.Generic;

namespace Module_2_Review;

public class Student
{
    //student information
    public string Name { get; set; } // name property
    public int ID { get; set; } // ID property
    public List<double> Grades { get; set; } = new List<double>(); // Grades property
    
    //method for single grade
    public void AddGrade(double grade)
    {
        Grades.Add(grade); // add grade to Grades list
    }
    // 
}