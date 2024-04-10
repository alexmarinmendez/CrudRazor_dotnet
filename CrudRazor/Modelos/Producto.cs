using System.ComponentModel.DataAnnotations;

namespace CrudRazor.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre del producto")]
        public string NombreProducto { get; set; }
        [Display(Name = "Descripción del producto")]
        public string Descripcion { get; set; }
        [Display(Name = "Cantidad en stock")]
        public int EnStock { get; set; }
        public int Precio { get; set; }
        [Display(Name = "Fecha de creación")]
        public DateTime FechaCreacion { get; set; }

    }
}
