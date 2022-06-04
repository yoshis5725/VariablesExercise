using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Chase";
            int dogAge = 10;
            char behaviorGrade = 'A';
            bool barks = true;
            double dinnerCost = 35.43;
            decimal tipAmount = 12.5M;

            Console.WriteLine($"I have a dog by the name of {dogName}. He is {dogAge} years old. {dogName} has a behavior grade of {behaviorGrade}");
            Console.WriteLine("Does my dog bark? : {0}", barks);
            Console.WriteLine($"Total cost of dinner was ${dinnerCost}, plus the ${tipAmount}");
        }
    }
}

