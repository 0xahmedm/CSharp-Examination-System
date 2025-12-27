using System;

namespace ExaminationSystem
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(int time, QuestionList questions, Subject subject)
            : base(time, questions, subject)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine($"Practice Exam for {Subject}");
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

            Console.WriteLine("----- Correct Answers -----");
            foreach (var q in Questions)
            {
                Console.WriteLine(q.Header);
                foreach (var ans in q.Answers)
                {
                    if (ans.IsCorrect)
                        Console.WriteLine($"Correct: {ans.Text}");
                }
                Console.WriteLine();
            }
        }
    }
}
