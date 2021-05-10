using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorio.IRepositorio
{
  public interface ILibroRepositorio
    {

        public Task<LibroDTO> AgregarLibro(LibroDTO libroDTO);
        public Task<LibroDTO> ActualizarLibro(int LibroId,LibroDTO libroDTO);
        public Task<LibroDTO> ObtenerLibro(int LibroId);
        public Task<IAsyncEnumerable<LibroDTO>> ObtenerListaLibro();
        public Task<LibroDTO> ExisteNombreLibro(string Nombre);

        public Task<int> EliminarLibro(int LibroId);

    }
}
