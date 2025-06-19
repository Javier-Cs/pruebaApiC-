using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaApiC_.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string Name { get; set; } = null;

        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "La descripción no puede exceder los 200 caracteres.")]
        public string Description { get; set; } = null!;

        [Column(TypeName ="decimal(18,2)")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        public decimal Price { get; set; }
    }
}
