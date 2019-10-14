using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor {
        public string InstructorFirstName {get; set;}
        public string InstructorLastName {get; set;}
        public string InstructorSlackHandle {get; set;}
        public Cohort InstructorCohort {get; set;}
        public string InstructorSpecialty {get; set;}
        public Student InstructorsStudent {get; set;}
        public void SetInstructorCohort(Cohort cohort)
        {
            InstructorCohort = cohort;
        }
        public void assignExerciseToStudent(Student student, Exercise exercise)
        {
            student.AssignedExercisesList.Add(exercise);
        }
    }
}