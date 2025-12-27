using System;

namespace ExaminationSystem
{
    internal class QuestionList : List<Question>
    {
        private string filePath;

        public QuestionList(string filePath)
        {
            this.filePath = filePath;

            if (!File.Exists(filePath))
            {
                using (var fs = File.Create(filePath)) { }
            }
        }

        public new void Add(Question q)
        {
            base.Add(q);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("----- QUESTION -----");
                writer.WriteLine(q.ToString());
                writer.WriteLine("Answers:");

                for (int i = 0; i < q.Answers.Count; i++)
                {
                    var ans = q.Answers[i];
                    writer.WriteLine($"{i + 1}) {ans.Text} {(ans.IsCorrect ? "(Correct)" : "")}");
                }

                writer.WriteLine();
            }
        }
    }
}
