using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISES
            Exercise Exercise1 = new Exercise();
            Exercise1.Name = "Exercise1";
            Exercise1.Language = "C#";

            Exercise Exercise2 = new Exercise();
            Exercise2.Name = "Execrcise2";
            Exercise2.Language = "C#";

            Exercise Exercise3 = new Exercise();
            Exercise3.Name = "Exercise3";
            Exercise3.Language = "C#";

            Exercise Exercise4 = new Exercise();
            Exercise4.Name = "Exercise4";
            Exercise4.Language = "C#";

            // COHORT   
            Cohort Cohort1 = new Cohort();

            Cohort Cohort2 = new Cohort();

            Cohort Cohort3 = new Cohort();

            Cohort Cohort4 = new Cohort();

            // STUDENT
            Student Dan = new Student();
            Dan.FirstName = "Dan";
            Dan.LastName = "Brewer";
            Dan.SlackHandle = "danbrewer";

            Student Asia = new Student();
            Asia.FirstName = "Asia";
            Asia.LastName = "Carter";
            Asia.SlackHandle = "asiacarter";

            Student Brittany = new Student();
            Brittany.FirstName = "Brittany";
            Brittany.LastName = "Ramos-Janeway";
            Brittany.SlackHandle = "brittanyramos-janeway";

            Student Austin = new Student();
            Austin.FirstName = "Austin";
            Austin.LastName = "Blade";
            Austin.SlackHandle = "austinblade";

            Student Megan = new Student();
            Megan.FirstName = "Megan";
            Megan.LastName = "Cruzen";
            Megan.SlackHandle = "megancruzen";

            Student Cole = new Student();
            Cole.FirstName = "Cole";
            Cole.LastName = "Bryant";
            Cole.SlackHandle = "colebryant";

            Student Mary = new Student();
            Mary.FirstName = "Mary";
            Mary.LastName = "Remo";
            Mary.SlackHandle = "maryremo";

            Student Allison = new Student();
            Allison.FirstName = "Allison";
            Allison.LastName = "Collins";
            Allison.SlackHandle = "allisoncollins";

            Student JD = new Student();
            JD.FirstName = "JD";
            JD.LastName = "Wheeler";
            JD.SlackHandle = "JDWheeler";

            //  Create Student List
            Cohort1.Students = new List<Student>();
            Cohort2.Students = new List<Student>();
            Cohort3.Students = new List<Student>();
            Cohort4.Students = new List<Student>();

            Cohort1.Students.Add(Dan);
            Cohort2.Students.Add(Asia);
            Cohort3.Students.Add(Brittany);
            Cohort4.Students.Add(Austin);
            Cohort1.Students.Add(Megan);
            Cohort2.Students.Add(Cole);
            Cohort3.Students.Add(Mary);
            Cohort4.Students.Add(Allison);
            Cohort1.Students.Add(JD);



            // INSTRUCTOR
            Instructor Andy = new Instructor();
            Andy.FirstName = "Andy";
            Andy.LastName = "Collins";
            Andy.SlackHandle = "AndyCollins";

            Instructor Jisie = new Instructor();
            Jisie.FirstName = "Jisie";
            Jisie.LastName = "David";
            Jisie.SlackHandle = "JisieDavid";

            Instructor Steve = new Instructor();
            Steve.FirstName = "Steve";
            Steve.LastName = "Brownlee";
            Steve.SlackHandle = "SteveBrownlee";

            Instructor Brenda = new Instructor();
            Brenda.FirstName = "Brenda";
            Brenda.LastName = "Long";
            Brenda.SlackHandle = "brendalong";

            // Create Instructor List
            Cohort1.Instructors = new List<Instructor>();
            Cohort2.Instructors = new List<Instructor>();
            Cohort3.Instructors = new List<Instructor>();
            Cohort4.Instructors = new List<Instructor>();

            Cohort1.Instructors.Add(Andy);
            Cohort2.Instructors.Add(Jisie);
            Cohort3.Instructors.Add(Steve);
            Cohort4.Instructors.Add(Brenda);

            // Create Cohort List
            List<Cohort> Cohorts = new List<Cohort>();

            Cohorts.Add(Cohort1);
            Cohorts.Add(Cohort2);
            Cohorts.Add(Cohort3);
            Cohorts.Add(Cohort4);


            Brenda.Assign(Austin, Exercise2);
            Brenda.Assign(Allison, Exercise3);
            Steve.Assign(Mary, Exercise2);
            Steve.Assign(Brittany, Exercise3);
            Andy.Assign(Dan, Exercise1);
            Andy.Assign(Megan, Exercise3);
            Andy.Assign(JD, Exercise2);
            Andy.Assign(Dan, Exercise3);
            Jisie.Assign(Cole, Exercise2);
            Jisie.Assign(Asia, Exercise4);

            // Challenge - Create a list of students. Add all of the student instances to it.

            foreach(Cohort cohort in Cohorts) {

                List<Student> students = new List<Student>();

                foreach(Student student in cohort.Students){
                    students.Add(student);

                    List<Exercise> exercises = new List<Exercise>();

                    foreach(Exercise exercise in student.Exercises){
                        exercises.Add(exercise);
                        Console.WriteLine($"{student.FirstName} is working on {exercise.Name}");
                    }

        }
    }
}
    }
}