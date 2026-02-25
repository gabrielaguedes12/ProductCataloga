using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public List<Product> Products { get; set; }

    public void OnGet()
    {
        Products = new List<Product>
        {
            new Product { Name = "Notebook", Price = 2100 },
            new Product { Name = "Mouse", Price = 500 },
            new Product { Name = "Teclado", Price = 600 }
        };
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}