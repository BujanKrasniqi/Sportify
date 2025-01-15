using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IList<Product>> GetProductBrandsAsync(string brandName);
    Task<IList<Product>> GetProductTypesAsync(string typeName);
    Task<IList<Product>> GetProductsByNameAsync(string productName);
    Task<IList<Product>> GetProductsByPriceRangeAsync(decimal minPrice, decimal maxPrice);
    Task<IList<Product>> GetProductsWithSufficientStockAsync();
    Task<IList<Product>> GetLowStockProductsAsync();
    Task<IList<Product>> GetOutOfStockProductsAsync();
    Task<IList<Product>> GetHighlyRatedProductsAsync();
    Task<IList<Product>> GetLowestRatedProductsAsync();
    Task<IList<Product>> GetProductsByMinimumReviewCountAsync(int minReviews);
    Task<IList<Product>> GetTopRatedProductsByReviewCountAsync(int minReviews);
    Task<IList<Product>> GetProductsWithNoReviewsAsync();
}
