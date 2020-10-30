using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Element
    {
        public int Id { get; }
        public int Priority { get; }
        public string Name { get; }
        public string Difficulty { get; }
        public decimal Worth { get; }


        public Element()
        {
           
        }

        public Element(int id, int priority, string name, string difficulty, decimal worth)
        {
            Id = id;
            Priority = priority;
            Name = name;
            Difficulty = difficulty;
            Worth = worth;
        }
    }
}
