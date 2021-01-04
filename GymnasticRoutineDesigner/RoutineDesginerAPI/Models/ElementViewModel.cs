using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymnasticRoutineDesigner.Models
{
    public class ElementViewModel
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public double Worth { get; set; }

        public ElementViewModel()
        {

        }

        public ElementViewModel(int id, int priority, string name, string difficulty, double worth)
        {
            Id = id;
            Priority = priority;
            Name = name;
            Difficulty = difficulty;
            Worth = worth;
        }
    }
}
