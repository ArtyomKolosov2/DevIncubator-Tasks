using System;
using System.Collections.Generic;
using System.Text;

namespace Module10.Data
{
    public class TableModel
    {
        public TableModel()
        {
            Id = InstanceCount;
            InstanceCount += 1;
        }
        private static int InstanceCount { get; set; } = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Id, 3} {Name ?? "null", 11} {SurName ?? "null", 11} {Age, 4}";
        }

    }
}
