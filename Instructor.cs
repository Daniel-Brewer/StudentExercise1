using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Instructor
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string SlackHandle { get; set;}
        public string CohortNumber { get; set;}
        public List<Exercise> Exercises { get; set;}
        public void Assign(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
            Console.WriteLine($"{FirstName} assigned {exercise.Name} to {student.FirstName}");
        }
        
    }

}