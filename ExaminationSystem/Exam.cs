using System;

namespace ExaminationSystem
{
    internal abstract class Exam
    {
        public int Time { get; set; } 
        public QuestionList Questions { get; set; }
        public Dictionary<Question, Answer> AnswersGiven { get; set; }
        public Subject Subject { get; set; }

        protected Exam(int time, QuestionList questions, Subject subject)
        {
            Time = time;
            Questions = questions;
            Subject = subject;
            AnswersGiven = new Dictionary<Question, Answer>();
        }

        public abstract void ShowExam();
    }
}
