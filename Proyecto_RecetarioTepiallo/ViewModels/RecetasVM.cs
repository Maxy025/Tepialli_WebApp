using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proyecto_RecetarioTepiallo.ViewModels
{
    public class RecetasVM
    {

        //Nombre de la receta, el cual es obligatorio
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        //Es cena, comida, desayuno, postre
        [Required]
        public string Categoria { get; set; }

        //Se escribe toda la receta, ingredientes y pasos.
        [Required]
        [StringLength(4000)]
        [Display(Name = "Escribe las instrucciones para llevar acabo la receta")]
        public string Descripcion { get; set; }

        //Solo selecciona el como se sierve, si frio o caliente
        [Required]
        public string TipoServicio { get; set; }

        //Para cuantas personas es
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La porción debe ser al menos 1.")]
        public int Porcion { get; set; }

        //Que tipo de comida es mexicana, asiatica, etc.
        [StringLength(50)]
        [Display(Name = "Origen de la receta")]
        public string TipoComida { get; set; }

        //Cuanto tarda en prepararse
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El tiempo de preparación no puede ser negativo.")]
        public int TiempoPreparacion { get; set; } // En minutos

        //Cuanto tiempo tarda en cocerse 
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El tiempo de cocción no puede ser negativo.")]
        public int TiempoCoccion { get; set; } // En minutos

        [Required(ErrorMessage = "Seleccione un archivo")]
        [Display(Name = "Imagen para Portada")]
        public IFormFile Imagen { get; set; }
    }
}
