using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetCarsWebsite.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Hp { get; set; }
        [DisplayName("Weight")]
        public int Mass { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
