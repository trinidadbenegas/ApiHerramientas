using HerramientasApi.Data;
using HerramientasApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HerramientasApi.Services
{
    public class HerramientasService : IHerramientasService
    {
        private readonly AppDbContext _context;

        public HerramientasService(AppDbContext context)
        {

            _context = context;

        }
        public void CrearHerramienta(Herramienta herramienta)
        {
            _context.Herramientas.Add(herramienta);
            _context.SaveChanges();
        }

        public void EditarHerramienta(int id, Herramienta herramienta)
        {
            
            if (id == herramienta.Id)
            {

                _context.Entry(herramienta).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void EliminarHerramienta(int id, Herramienta herramienta)
        {
            _context.Remove(herramienta);
            _context.SaveChanges();
        }

        public Herramienta ObtenerHerramientaPorId(int id)
        {
            return _context.Herramientas.Find(id);
            
        }

        public List<Herramienta> ObtenerHerramientas()
        {
            return _context.Herramientas.ToList();
            
        }
    }
}
