using System.ComponentModel.DataAnnotations;

namespace HerramientasApi.Data.ModelVM
{
    public class HerramientaVM
    {
        [Required]
        public string TipoHerramienta { get; set; }
        [Required]
        public bool Disponibilidad { get; set; } = true;
        [Required]
        public string NombreReservante { get; set; }
        [Required]
        public string ApellidoReservante { get; set; }
        [Required]
        public int Dni { get; set; }
        [Required]
        public string Direccion { get; set; }
    }
}
