using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class LibroDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor ingresa Nombre de libro")]
        public string Nombre { get; set; }
        [Range(10, 100, ErrorMessage = "El precio regular debe estar entre 10 y 100")]
        public double PrecioRegular { get; set; }
        [Required(ErrorMessage = "Por favor ingresa Nombre de Autor")]
        public string Autor { get; set; }
        public string Detalles { get; set; }
    }
}
