using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Club
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
