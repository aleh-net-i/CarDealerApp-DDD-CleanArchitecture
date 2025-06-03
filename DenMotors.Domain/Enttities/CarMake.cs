using System.ComponentModel.DataAnnotations;

namespace DenMotors.Web.Data
{
    /// <summary>
    /// Represents a car manufacturer (make).
    /// </summary>
    public class CarMake
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
    }
} 