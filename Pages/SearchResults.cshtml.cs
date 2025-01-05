using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class SearchResultsModel : PageModel
{
    public string Query { get; set; }
    public List<Product> SearchResults { get; set; } = new List<Product>();

    public void OnGet(string query)
    {
        Query = query;

        // Mock data (replace with actual database query logic)
        var products = new List<Product>
        {
            new Product { Name = "Trendy Frock", Price = 20.00, Image = "item1.jpg" },
            new Product { Name = "Leather Jacket", Price = 40.00, Image = "men3.jpg" },
            new Product { Name = "Casual T-Shirt", Price = 10.00, Image = "kids2.jpg" }
        };

        // Filter products based on query
        SearchResults = products.FindAll(p => p.Name.ToLower().Contains(query.ToLower()));
    }
}

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Image { get; set; }
}
