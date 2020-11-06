using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public class Element
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public decimal Worth { get; set; }


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
