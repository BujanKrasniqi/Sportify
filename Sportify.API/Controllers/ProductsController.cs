using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Sportify.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    // GET: api/v1/products
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
    {
        var products = await _productRepository.GetAllAsync(p => p.ProductType, p => p.ProductBrand);
        return Ok(products);
    }

    // GET: api/v1/products/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProductById(int id)
    {
        var product = await _productRepository.GetByIdAsync(id, p => p.ProductType, p => p.ProductBrand);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    // POST: api/v1/products
    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct([FromBody] Product newProduct)
    {
        await _productRepository.AddAsync(newProduct);
        return CreatedAtAction(nameof(GetProductById), new { id = newProduct.Id }, newProduct);
    }

    // PUT: api/v1/products/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product updatedProduct)
    {
        var product = await _productRepository.GetByIdAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        // Update product properties
        product.Name = updatedProduct.Name;
        product.Description = updatedProduct.Description;
        product.Price = updatedProduct.Price;
        product.PictureUrl = updatedProduct.PictureUrl;
        product.ProductTypeId = updatedProduct.ProductTypeId;
        product.ProductBrandId = updatedProduct.ProductBrandId;

        await _productRepository.UpdateAsync(product);

        return NoContent();
    }

    // DELETE: api/v1/products/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        await _productRepository.DeleteAsync(product);

        return NoContent();
    }

    [HttpGet("byBrand/{brandName}")]
    public async Task<ActionResult<IList<Product>>> GetProductsByBrand(string brandName)
    {
        var products = await _productRepository.GetProductBrandsAsync(brandName);

        if (!products.Any())
        {
            return NotFound($"Nuk u gjetën produkte për brand-in: {brandName}");
        }

        return Ok(products);
    }

    [HttpGet("byType/{typeName}")]
    public async Task<ActionResult<IList<Product>>> GetProductsByType(string typeName)
    {
        var products = await _productRepository.GetProductTypesAsync(typeName);

        if (!products.Any())
        {
            return NotFound($"Nuk u gjetën produkte për llojin: {typeName}");
        }

        return Ok(products);
    }



    [HttpGet("SearchProductByName")]
    public async Task<IActionResult> GetProductsByName(string name)
    {
        var products = await _productRepository.GetProductsByNameAsync(name);

        if (products == null || !products.Any())
        {
            return NotFound($"Nuk u gjet produkti me emrin: {name}");

        }

        return Ok(products);
    }

    //Produktet sipas çmimeve
    [HttpGet("FilterProductByPrice")]
    public async Task<IActionResult> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
    {
        var products = await _productRepository.GetProductsByPriceRangeAsync(minPrice, maxPrice);

        if (products == null || !products.Any())
        {
            return NotFound("Nuk u gjet asnjë produkt në çmimet e specifikuara.");
        }

        return Ok(products);
    }

    // Produktet StockQuantity > 10
    [HttpGet("WithSufficientStock")]
    public async Task<IActionResult> GetProductsWithSufficientStock()
    {
        var products = await _productRepository.GetProductsWithSufficientStockAsync();
        
        if (products == null)
        {
            return NotFound("Nuk u gjet asnjë produkt.");
        }
        return Ok(products);
    }

    // Produktet StockQuantity  <= 10
    [HttpGet("LowStock")]
    public async Task<IActionResult> GetLowStockProducts()
    {
        var products = await _productRepository.GetLowStockProductsAsync();

        if (products == null)
        {
            return NotFound("Nuk u gjet asnjë produkt.");
        }

        return Ok(products);
    }

    //(StockQuantity == 0)
    [HttpGet("OutOfStock")]
    public async Task<IActionResult> GetOutOfStockProducts()
    {
        var products = await _productRepository.GetOutOfStockProductsAsync();

        if (products == null)
        {
            return NotFound("Nuk u gjet asnjë produkt.");
        }

        return Ok(products);
    }

    // Produktet me vlerësim të lartë
    [HttpGet("HighlyRatedProducts")]
    public async Task<IActionResult> GetHighlyRatedProductsAsync()
    {
        var products = await _productRepository.GetHighlyRatedProductsAsync();

        if (products == null || products.Count == 0)
        {
            return NotFound("Nuk u gjet asnjë produkt.");
        }

        return Ok(products);
    }

    // Produktet me vlerësim të ulët
    [HttpGet("LowestRatedProducts")]
    public async Task<IActionResult> GetLowestRatedProductsAsync()
    {
        var products = await _productRepository.GetLowestRatedProductsAsync();

        if (products == null || products.Count == 0)
        {
            return NotFound("Nuk u gjet asnjë produkt.");
        }

        return Ok(products);
    }

    // Produktet me numër minimal komentesh
    [HttpGet("Minimum-reviews/{minReviews}")]
    public async Task<IActionResult> GetProductsByMinimumReviewCountAsync(int minReviews)
    {
        var products = await _productRepository.GetProductsByMinimumReviewCountAsync(minReviews);

        if (products == null || !products.Any())
        {
            return NotFound("Nuk u gjet asnjë produkt.");
        }

        return Ok(products);
    }

    //Produktet me vlerësimin mesatar më të lartë, por me numrin minimal të komenteve
    [HttpGet("Top-Rated/{minReviews}")]
    public async Task<IActionResult> GetTopRatedProductsByReviewCountAsync(int minReviews)
    {
        var products = await _productRepository.GetTopRatedProductsByReviewCountAsync(minReviews);

        if (products == null || !products.Any())
        {
            return NotFound("Nuk u gjet asnjë produkt.");
        }

        return Ok(products);
    }

    //Produkte pa komente
    [HttpGet("No-reviews")]
    public async Task<IActionResult> GetProductsWithNoReviewsAsync()
    {
        var products = await _productRepository.GetProductsWithNoReviewsAsync();

        if (products == null || !products.Any())
        {
            return NotFound("Nuk u gjet asnjë produkt.");
        }

        return Ok(products);
    }





}
