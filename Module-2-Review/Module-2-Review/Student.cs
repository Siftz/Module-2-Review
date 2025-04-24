using System;
using System.Collections.Generic;
using Module_2_Review;

namespace Module_2_Review
{
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

        //method for adding multiple grades
        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades); // adds all grades to the grades list
        }

        // average grade method
        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0) return 0; // return 0 if no grades
            double total = 0;
            foreach (double grade in Grades)
            {
                total += grade; // sum of grades
            }

            return total / Grades.Count; // calc and return the average grades
        }

        //public void AddGrade(double grade, double d, double d1)
        //{
        //    throw new NotImplementedException();
        //}
    }
}