using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Tournament
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
