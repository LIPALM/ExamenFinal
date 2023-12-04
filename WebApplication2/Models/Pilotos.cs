using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication2.Models
{
    public class Pilotos

    {
        [Key]
        public int idPiloto { get; set; }
        public string NumeroLicencia { get; set; }
        public string Restricciones { get; set; }
        public int Salario { get; set; }
        public string Turno{ get; set; }
    }
}