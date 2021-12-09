using System;
using System.Collections.Generic;
using System.Text;

namespace Zawodnicy.Core.Domain
{
    public class Coach
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
