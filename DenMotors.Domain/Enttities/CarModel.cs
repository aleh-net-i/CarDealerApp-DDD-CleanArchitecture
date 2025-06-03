using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DenMotors.Web.Data
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey("CarMake")]
        public int CarMakeId { get; set; }
        public CarMake CarMake { get; set; } = null!;
    }
} 