using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zawodnicy.WebApp.Models
{
    public class CoachVM
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
