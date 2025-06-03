using System;
using System.ComponentModel.DataAnnotations;

namespace DenMotors.Web.Data;

public class Car
{
    public int Id { get; set; }

    [Required]
    [CustomValidation(typeof(Car), nameof(ValidatePurchaseDate))]
    public DateTime PurchaseDate { get; set; }

    [Required(ErrorMessage = "Car status is required.")]
    public int CarStatusId { get; set; }
    public CarStatus? CarStatus { get; set; }

    [Required]
    public int CarMakeId { get; set; }
    public CarMake? CarMake { get; set; }

    [Required]
    public int CarModelId { get; set; }
    public CarModel? CarModel { get; set; }

    [Required, StringLength(50)]
    public string Colour { get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string ChassisNumber { get; set; } = string.Empty;

    [Required, StringLength(100)]
    public string SupplierName { get; set; } = string.Empty;

    [StringLength(50)]
    public string RegistrationNumber { get; set; } = string.Empty;

    [Required]
    [Range(0.01, 1000000, ErrorMessage = "Purchase cost must be greater than 0.")]
    public decimal PurchaseCost { get; set; }

    [Range(0, 1000000)]
    public decimal SalePrice { get; set; }

    public DateTime? DateOfSale { get; set; }

    [Range(0, 1000000)]
    public decimal Deposit { get; set; }

    [StringLength(1000)]
    public string Comments { get; set; } = string.Empty;

    public static ValidationResult? ValidatePurchaseDate(DateTime purchaseDate, ValidationContext context)
    {
        if (purchaseDate < DateTime.Now.AddYears(-1))
            return new ValidationResult("Purchase date must be within the last year.");
        return ValidationResult.Success;
    }
} 