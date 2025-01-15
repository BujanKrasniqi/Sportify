﻿namespace Core.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string PictureUrl { get; set; }

    public int ProductTypeId { get; set; }
    public int ProductBrandId { get; set; }

    public int StockQuantity { get; set; }

    // Navigation Properties
    public ProductType? ProductType { get; set; }
    public ProductBrand? ProductBrand { get; set; }

    public ICollection<Review> Reviews { get; set; } 
}
