using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student {
        public string StudentFirstName {get; set;}
        public string StudentLastName {get; set;}
        public string StudentSlackHandle {get; set;}
        public Cohort StudentCohort {get; set;}
        public void SetStudentCohort(Cohort cohort)
        {
            StudentCohort = cohort;
        }
        public List<Exercise> AssignedExercisesList {get; set;} = new List<Exercise>();

        public void PrintStudentExercises()
        {
            foreach(Exercise exercise in AssignedExercisesList){
            Console.Write($"{StudentFirstName} is working on {exercise.ExerciseName}");
            }
        }
    }
}