using System;
using ExaminationSystem;

namespace ExamApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------
            // 1 Create Subject
            // ---------------------------
            Subject math = new Subject("Mathematics", "MATH101");

            // ---------------------------
            // 2️ Create QuestionList
            // ---------------------------
            QuestionList qList = new QuestionList("math_questions.txt");

            // ---------------------------
            // 3️ Add Questions
            // ---------------------------
            // True/False
            qList.Add(new TrueFalseQuestion(
                "Q1",
                "C# is an object-oriented programming language.",
                5,
                true
            ));

            // Choose One
            qList.Add(new ChooseOneQuestion(
                "Q2",
                "Which language is primarily used for .NET development?",
                5,
                new List<string> { "Java", "C#", "Python", "C++" },
                1
            ));

            // Choose All
            qList.Add(new ChooseAllQuestion(
                "Q3",
                "Select all languages that can run on .NET platform.",
                5,
                new List<string> { "C#", "F#", "Java", "VB.NET" },
                new List<int> { 0, 1, 3 }
            ));

            // ---------------------------
            // 4️ Run Practice Exam
            // ---------------------------
            Console.WriteLine("=== Practice Exam ===\n");
            PracticeExam practice = new PracticeExam(30, qList, math);
            practice.ShowExam();

            // ---------------------------
            // 5️ Run Final Exam
            // ---------------------------
            Console.WriteLine("\n=== Final Exam ===\n");
            FinalExam final = new FinalExam(60, qList, math);
            final.ShowExam();

            Console.WriteLine("\nExams Completed!");
        }
    }
}
