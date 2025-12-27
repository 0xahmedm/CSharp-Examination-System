using System;

namespace ExaminationSystem
{
    internal class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(
            string header,
            string body,
            int marks,
            List<string> choices,
            List<int> correctAnswerIndices)
            : base(header, body, marks)
        {
            foreach (int index in correctAnswerIndices)
            {
                if (index < 0 || index >= choices.Count)
                    throw new ArgumentException("Invalid correct answer index");
            }

            for (int i = 0; i < choices.Count; i++)
            {
                bool isCorrect = correctAnswerIndices.Contains(i);
                Answers.Add(new Answer(choices[i], isCorrect));
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
