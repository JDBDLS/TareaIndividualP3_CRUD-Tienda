using System.ComponentModel.DataAnnotations;

namespace TareaIndividualP3_CRUD_Tienda.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, 100000.00, ErrorMessage = "El precio debe ser un valor positivo.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "La cantidad en stock es obligatoria.")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser un número entero positivo.")]
        public int Stock { get; set; }
    }
}