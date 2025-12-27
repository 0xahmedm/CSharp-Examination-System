using System;

namespace ExaminationSystem
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int marks, bool correctAnswer)
            : base(header, body, marks)
        {
            Answers.Add(new Answer("True", correctAnswer == true));
            Answers.Add(new Answer("False", correctAnswer == false));
        }

        public override void Display()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine("1) True");
            Console.WriteLine("2) False");
        }
    }
}
