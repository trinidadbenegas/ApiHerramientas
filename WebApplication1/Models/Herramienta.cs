using System.ComponentModel.DataAnnotations;

namespace HerramientasApi.Models
{
    public class Herramienta
    {
        
           
            public int Id { get; set; }
            
            public string TipoHerramienta { get; set; }
            
            public bool Disponibilidad { get; set; } 
            
            public string NombreReservante { get; set; }
            
            public string ApellidoReservante { get; set; }
            
            public int Dni { get; set; }
            
            public string Direccion { get; set; }



     }
    
}
