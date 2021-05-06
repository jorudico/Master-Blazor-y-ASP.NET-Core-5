using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaProducto_Server.Modelo
{
    public class LibroBlazor
    {
        public int Id { get; set; }
        public string NombreLibro { get; set; }
        public double Precio { get; set; }
        public bool Agotado { get; set; }

        public List<LibroTipo> LibroTipo { get; set; }
    }
}
