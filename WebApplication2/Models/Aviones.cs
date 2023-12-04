using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Aviones
    {
        [Key]
        public int idAvion{ get; set; }
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Peso { get; set; }
        public int Capacidad { get; set; }

    }
}