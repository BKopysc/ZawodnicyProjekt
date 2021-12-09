using System;
using System.Collections.Generic;
using System.Text;

namespace Zawodnicy.Core.Domain
{
    public class SkiJump
    {
        public int Id { get; set; }
        public City City { get; set; }
        public String Country { get; set; }
        public String Name { get; set; }
        public int K { get; set; }
        public int Judge { get; set; }
    }
}
