using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TareaIndividualP3_CRUD_Tienda.Models;
using TareaIndividualP3_CRUD_Tienda.Data;

namespace TareaIndividualP3_CRUD_Tienda.Pages.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ProductRepository.AddProduct(Product);
            return RedirectToPage("/Index");
        }
    }
}