using System;

namespace ExaminationSystem
{
    internal class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(
            string header,
            string body,
            int marks,
            List<string> choices,
            int correctAnswerIndex)
            : base(header, body, marks)
        {
            if (correctAnswerIndex < 0 || correctAnswerIndex >= choices.Count)
                throw new ArgumentException("Invalid correct answer index");

            for (int i = 0; i < choices.Count; i++)
            {
                Answers.Add(new Answer(choices[i], i == correctAnswerIndex));
            }
        }

        public override void Display()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);

            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Answers[i]}");
            }
        }
    }
}
