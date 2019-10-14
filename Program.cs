using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Student EllieAsh = new Student()
            { 
                StudentFirstName = "Ellie", 
                StudentLastName = "Ash", 
                StudentSlackHandle = "@EllieAsh"
            };
            Student BennettFoster = new Student()
            { 
                StudentFirstName = "Bennett", 
                StudentLastName = "Foster", 
                StudentSlackHandle = "@BennettFoster"
            };
            Student MichaelStiles = new Student()
            { 
                StudentFirstName = "Michael", 
                StudentLastName = "Stiles", 
                StudentSlackHandle = "@MichaelStiles"
            };
            Student HaroonIqbal = new Student()
            { 
                StudentFirstName = "Haroon", 
                StudentLastName = "Iqbal", 
                StudentSlackHandle = "@HaroonIqbal",
            };
            Instructor AndyCollins = new Instructor()
            { 
                InstructorFirstName = "Andy", 
                InstructorLastName = "Collins", 
                InstructorSlackHandle = "@AndyCollins",
                InstructorSpecialty = "Deadpan"
            };
            Instructor BryanNilsen = new Instructor()
            { 
                InstructorFirstName = "Bryan", 
                InstructorLastName = "Nilsen", 
                InstructorSlackHandle = "@BryanNilsen",
                InstructorSpecialty = "Pep Talks"
            };
            Cohort ThirtyFour = new Cohort()
            { 
                CohortName = "34",
            };
            Cohort ThirtyFive = new Cohort()
            { 
                CohortName = "35",
            };
            Exercise DailyJournal1 = new Exercise()
            { 
                ExerciseLanguage = "Vanilla JS",
                ExerciseName = "Daily Journal 1"
            };
            Exercise ReactNutshell = new Exercise()
            { 
                ExerciseLanguage = "React",
                ExerciseName = "React Nutshell"
            };
            Exercise ChickenMonkey = new Exercise()
            { 
                ExerciseLanguage = "Vanilla JS",
                ExerciseName = "ChickenMonkey"
            };

            List<Student> allStudentsList = new List<Student>()
            {
                EllieAsh,
                BennettFoster,
                HaroonIqbal,
                MichaelStiles
            };
            List<Instructor> allInstructorsList = new List<Instructor>()
            {
                AndyCollins,
                BryanNilsen
            };
            List<Exercise> allExercisesList = new List<Exercise>()
            {
                DailyJournal1,
                ReactNutshell,
                ChickenMonkey
            };
            List<Cohort> allCohortsList = new List<Cohort>()
            {
                ThirtyFour,
                ThirtyFive
            };
            allExercisesList.Where(e => e.ExerciseName == "Vanilla JS");

            

            ThirtyFour.addStudentToCohortList(EllieAsh);
            EllieAsh.SetStudentCohort(ThirtyFour);

            ThirtyFour.addStudentToCohortList(BennettFoster);
            BennettFoster.SetStudentCohort(ThirtyFour);

            ThirtyFive.addStudentToCohortList(MichaelStiles);
            MichaelStiles.SetStudentCohort(ThirtyFive);

            ThirtyFive.addStudentToCohortList(HaroonIqbal);
            HaroonIqbal.SetStudentCohort(ThirtyFive);

            ThirtyFive.PrintStudents();
            Console.WriteLine();
            ThirtyFour.PrintStudents();

            AndyCollins.SetInstructorCohort(ThirtyFour);
            BryanNilsen.SetInstructorCohort(ThirtyFive);

            AndyCollins.assignExerciseToStudent(EllieAsh, ChickenMonkey);
            BryanNilsen.assignExerciseToStudent(BennettFoster, DailyJournal1);

            EllieAsh.PrintStudentExercises();
            BennettFoster.PrintStudentExercises();
        }
    }
}
