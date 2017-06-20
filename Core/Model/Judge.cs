using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Judge
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
