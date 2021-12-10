using System;
using System.Collections.Generic;
using System.Text;

namespace Zawodnicy.Infrastructure.DTO
{
    public class CoachDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
