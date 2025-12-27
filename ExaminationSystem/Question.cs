using System;

namespace ExaminationSystem
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }

        protected Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = new AnswerList();
        }

        public abstract void Display();

        public override string ToString()
        {
            return $"{Header}\n{Body}\nMarks: {Marks}";
        }
    }
}
