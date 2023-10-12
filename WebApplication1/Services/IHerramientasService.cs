using HerramientasApi.Models;

namespace HerramientasApi.Services
{
    public interface IHerramientasService
    {
        void CrearHerramienta(Herramienta herramienta);
        void EliminarHerramienta(int id, Herramienta herramienta);
        void EditarHerramienta(int id, Herramienta herramienta);

        public List<Herramienta> ObtenerHerramientas();
        public Herramienta ObtenerHerramientaPorId(int id);
    }
}
