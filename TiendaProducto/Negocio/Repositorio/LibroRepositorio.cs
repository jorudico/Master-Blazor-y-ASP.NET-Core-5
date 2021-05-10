using AccesoDatos.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Negocio.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Repositorio
{
    class LibroRepositorio : ILibroRepositorio
    {
        private readonly AplicacionDbContext _db;
        private readonly IMapper _mapper;

        public LibroRepositorio(AplicacionDbContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }



        public async Task<LibroDTO> ActualizarLibro(int LibroId, LibroDTO libroDTO)
        {
            try
            {
                if (LibroId == libroDTO.Id)
                {
                    Libro libroDetalles = await _db.Libro.FindAsync(LibroId);
                    Libro libro = _mapper.Map<LibroDTO, Libro>(libroDTO, libroDetalles);
                    libro.Autor = "";
                    libro.FechaActualizacion = DateTime.Now;
                    var updateLibro = _db.Libro.Update(libro);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Libro, LibroDTO>(updateLibro.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<LibroDTO> AgregarLibro(LibroDTO libroDTO)
        {
            Libro libro = _mapper.Map<LibroDTO, Libro>(libroDTO);
            libro.FechaCreacion = DateTime.Now;
            libro.Autor = "";
            var addLibro = await _db.Libro.AddAsync(libro);
            await _db.SaveChangesAsync();
            return _mapper.Map<Libro, LibroDTO>(addLibro.Entity);
        }

        public async Task<int> EliminarLibro(int LibroId)
        {
            var libroDetalles = await _db.Libro.FindAsync(LibroId);
            if (libroDetalles != null)
            {
                _db.Libro.Remove(libroDetalles);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<LibroDTO> ExisteNombreLibro(string Nombre)
        {
            try
            {
                LibroDTO libro = _mapper.Map<Libro, LibroDTO>(await _db.Libro.FirstOrDefaultAsync(x => x.Nombre.ToLower() == Nombre.ToLower()));
                return libro;
            }
            catch (Exception)
            {


                return null;
            }
        }

        public async Task<LibroDTO> ObtenerLibro(int LibroId)
        {
            try
            {
                LibroDTO libro = _mapper.Map<Libro, LibroDTO>(await _db.Libro.FirstOrDefaultAsync(x => x.Id == LibroId));
                return libro;
            }
            catch (Exception)
            {

                
                return null;
            }
        }

        public async Task<IEnumerable<LibroDTO>> ObtenerListaLibro()
        {
            try
            {
                IEnumerable<LibroDTO> libroDTOs =  _mapper.Map<IEnumerable<Libro>,IEnumerable<LibroDTO>>(_db.Libro);
                return libroDTOs;
            }
            catch (Exception)
            {

                return null;
            }
        }

        Task<IAsyncEnumerable<LibroDTO>> ILibroRepositorio.ObtenerListaLibro()
        {
            throw new NotImplementedException();
        }
    }
}
