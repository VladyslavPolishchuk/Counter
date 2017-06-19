using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Participant
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Pair
    {
        public Participant Male { get; set; }
        public Participant Female { get; set; }
    }
}
