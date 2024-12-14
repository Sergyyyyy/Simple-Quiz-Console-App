using System;

namespace Simple_Quiz_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Questions and Answers are editable to preferences 

            // Array of questions
            string[] questions = { 
                "1 + 1?",
                "Capital of the Philippines?", 
                "Organ responsible for pumping blood?",
                "What does OOP stand for?",
                "What is H2O?",
                "What day is on the 25th of December?",
                "What color is the sky?",
                "67 + 17?",
                "What is 5 x 40?",
                "Who won 2022 FIFA World Cup? (give full name)"
            };

            // Array of Answers
            string[] answers = {"2", "Manila", "Heart", "Object Oriented Programming", "Water", "Christmas", "Blue", "84", "200", "Lionel Messi" };
            int score = 0;

            // to loop through the questions
            for (int i = 0;  i < questions.Length; i++)
            {      
                // to ask the question
                Console.WriteLine($"{i + 1}. " + questions[i]);
                string input = "";
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("answer: ");
                    input = Console.ReadLine();

                    // Questions and Answers are checked if the index matches with both arrays
                    if (input.ToLower() == answers[i].ToLower())
                    {
                        Console.WriteLine();
                        Console.WriteLine("Correct!");
                        Console.WriteLine();

                        // increases the score everytime the answer is correct
                        score++;
                    }
                    else
                    {
                        // displays the correct answer
                        Console.WriteLine();
                        Console.WriteLine("Incorrect! The answer is " + answers[i]);
                        Console.WriteLine();
                    }
                } while (input == "");
                
            }

            //checks the score, decides if passing or not
            Console.WriteLine("Your score is " + score + " over " + questions.Length);

            if (score > 6)
            {
                Console.WriteLine("You have passed the Quiz!");
            }
            else
            {
                Console.WriteLine("You have failed the Quiz!");
            }

            Console.ReadKey();
        }
    }
}
