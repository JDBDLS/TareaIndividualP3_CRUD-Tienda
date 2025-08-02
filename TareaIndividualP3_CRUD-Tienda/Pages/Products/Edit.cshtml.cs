using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TareaIndividualP3_CRUD_Tienda.Data;
using TareaIndividualP3_CRUD_Tienda.Models;

namespace TareaIndividualP3_CRUD_Tienda.Pages.Products
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public IActionResult OnGet(int id)
        {
            Product = ProductRepository.GetById(id);
            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ProductRepository.UpdateProduct(Product);
            return RedirectToPage("/Index");
        }
    }
}