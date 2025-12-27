using System;

namespace ExaminationSystem
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, QuestionList questions, Subject subject)
            : base(time, questions, subject)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam for {Subject}");
            Console.WriteLine($"Time: {Time} minutes\n");

            foreach (var q in Questions)
            {
                q.Display();

                Console.Write("Your Answer: ");
                string input = Console.ReadLine();

                int selected;
                if (int.TryParse(input, out selected))
                {
                    if (selected >= 1 && selected <= q.Answers.Count)
                        AnswersGiven[q] = q.Answers[selected - 1];
                }
                else
                {
                    AnswersGiven[q] = null;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exam Completed. Answers are not displayed.");
        }
    }
}
