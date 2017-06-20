using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Participant
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Pair
    {
        [Key]
        public string Id { get; set; }
        public Participant Male { get; set; }
        public Participant Female { get; set; }
    }
}
