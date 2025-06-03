using System;
using System.ComponentModel.DataAnnotations;

namespace DenMotors.Web.Data;

public class Car
{
    public int Id { get; set; }

    [Required]
    public DateTime PurchaseDate { get; set; }

    [Required]
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

    [Range(0, 1000000)]
    public decimal PurchaseCost { get; set; }

    [Range(0, 1000000)]
    public decimal SalePrice { get; set; }

    public DateTime? DateOfSale { get; set; }

    [Range(0, 1000000)]
    public decimal Deposit { get; set; }

    [StringLength(1000)]
    public string Comments { get; set; } = string.Empty;
} 