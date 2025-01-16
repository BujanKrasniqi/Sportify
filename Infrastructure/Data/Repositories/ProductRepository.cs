using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private readonly SportifyDbContext _context;

    public ProductRepository(SportifyDbContext context) : base(context)
    {
        _context = context;
    }


    public async Task<IList<Product>> GetProductBrandsAsync(string brandName)
    {
        return await _context.Products
            .Include(p => p.ProductBrand)
            .Include(p => p.ProductType)
            .Where(p => p.ProductBrand.Name.ToLower() == brandName.ToLower())
            .ToListAsync();
    }

    public async Task<IList<Product>> GetProductTypesAsync(string typeName)
    {
        return await _context.Products
            .Include(p => p.ProductBrand)  
            .Include(p => p.ProductType)   
            .Where(p => p.ProductType.Name.ToLower() == typeName.ToLower()) 
            .ToListAsync();
    }

    public async Task<IList<Product>> GetProductsByNameAsync(string productName)
    {
        return await _context.Products
            .Where(p => p.Name.Contains(productName))
            .ToListAsync();
    }

    //Produktet sipas çmimeve
    public async Task<IList<Product>> GetProductsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        return await _context.Products
            .Where(p => p.Price >= minPrice && p.Price <= maxPrice)
            .OrderBy(p => p.Price) 
            .ToListAsync();
    }

    // Produktet StockQuantity > 10
    public async Task<IList<Product>> GetProductsWithSufficientStockAsync()
    {
        return await _context.Products
                              .Where(p => p.StockQuantity > 10)
                              .ToListAsync();
    }

    // Produktet StockQuantity  <= 10
    public async Task<IList<Product>> GetLowStockProductsAsync()
    {
        return await _context.Products
                              .Where(p => p.StockQuantity <= 10)
                              .ToListAsync();
    }

    // (StockQuantity == 0)
    public async Task<IList<Product>> GetOutOfStockProductsAsync()
    {
        return await _context.Products
                              .Where(p => p.StockQuantity == 0)
                              .ToListAsync();
    }

    // Metoda për produktet me vlerësim të lartë
    public async Task<IList<Product>> GetHighlyRatedProductsAsync()
    {
        return await _context.Products
            .Where(p => p.Reviews.Any())
            .Select(p => new
            {
                Product = p,
                AverageRating = p.Reviews.Average(r => r.Score)
            })
            .Where(p => p.AverageRating >= 4.5)
            .OrderByDescending(p => p.AverageRating)
            .Select(p => p.Product)
            .ToListAsync();
    }

    // Metoda për produktet me vlerësim të ulët
    public async Task<IList<Product>> GetLowestRatedProductsAsync()
    {
        return await _context.Products
            .Where(p => p.Reviews.Any())
            .Select(p => new
            {
                Product = p,
                AverageRating = p.Reviews.Average(r => r.Score)
            })
            .Where(p => p.AverageRating >= 1 && p.AverageRating <= 2)
            .OrderBy(p => p.AverageRating)
            .Select(p => p.Product)
            .ToListAsync();
    }

    // Metoda me numër minimal komentesh
    public async Task<IList<Product>> GetProductsByMinimumReviewCountAsync(int minReviews)
    {
        return await _context.Products
            .Where(p => p.Reviews.Count >= minReviews) 
            .ToListAsync();
    }


    //Produktet me vlerësimin mesatar më të lartë, por me numrin minimal të komenteve
    public async Task<IList<Product>> GetTopRatedProductsByReviewCountAsync(int minReviews)
    {
        return await _context.Products
            .Where(p => p.Reviews.Count >= minReviews) 
            .Where(p => p.Reviews.Average(r => r.Score) > 4) 
            .ToListAsync();
    }

    //Produkte pa komente
    public async Task<IList<Product>> GetProductsWithNoReviewsAsync()
    {
        return await _context.Products
            .Where(p => !p.Reviews.Any()) 
            .ToListAsync();
    }

}
