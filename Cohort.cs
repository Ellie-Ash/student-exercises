using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort {
        public string CohortName {get; set;}
        public List<Student> CohortStudents {get; set;} = new List<Student>();
        public void addStudentToCohortList(Student student)
        {
            CohortStudents.Add(student);
        }
        public void PrintStudents()
        {
            foreach(Student student in CohortStudents){
            Console.WriteLine($"Cohort {CohortName} includes {student.StudentFirstName} {student.StudentLastName} who is working on ");
            student.PrintStudentExercises();
            }
        }
        public List<Instructor> CohortInstructors {get; set;} = new List<Instructor>();
    }
}