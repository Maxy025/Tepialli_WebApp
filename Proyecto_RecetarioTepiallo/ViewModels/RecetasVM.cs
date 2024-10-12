using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proyecto_RecetarioTepiallo.ViewModels
{
    public class RecetasVM
    {

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Categoria { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoServicio { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La porción debe ser al menos 1.")]
        public int Porcion { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoComida { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El tiempo de preparación no puede ser negativo.")]
        public int TiempoPreparacion { get; set; } // En minutos

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El tiempo de cocción no puede ser negativo.")]
        public int TiempoCoccion { get; set; } // En minutos

        [Required(ErrorMessage = "Seleccione un archivo")]
        [Display(Name = "Imagen para Portada")]
        public IFormFile Imagen { get; set; }
    }
}
