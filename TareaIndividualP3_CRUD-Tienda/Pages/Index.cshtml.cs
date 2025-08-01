using Microsoft.AspNetCore.Mvc.RazorPages;
using TareaIndividualP3_CRUD_Tienda.Data;
using TareaIndividualP3_CRUD_Tienda.Models;

namespace TareaIndividualP3_CRUD_Tienda.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; } = new();

        public void OnGet()
        {
            Products = ProductRepository.Products;
        }
    }
}
