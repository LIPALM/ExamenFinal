    using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication2.Models
{
    public class PilotoAviones
    {
        [Key]
        public int idRelaciones { get; set; }
        public int idPiloto { get; set; }
        public int idAvion{ get; set; }
    }
}