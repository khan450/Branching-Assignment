using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score:");
            int score = Convert.ToInt32(Console.ReadLine());

            // If-else branching based on score
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // Ternary operator for a quick pass/fail check
            string passOrFail = (score >= 60) ? "You passed!" : "You failed!";
            Console.WriteLine(passOrFail);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
