using System;

namespace ExaminationSystem
{
    internal class Subject
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Subject(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return $"{Code}: {Name}";
        }
    }
}
