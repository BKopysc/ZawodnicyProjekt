using System;
using System.Collections.Generic;
using System.Text;

namespace Zawodnicy.Infrastructure.DTO
{
    public class SkiJumperDTO
    {
        //public int CoachId { get; set; }
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Country { get; set; }
        public DateTime DateBirth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
