using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progra_4_Progreso_1.Models
{
    public class Ricardo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public float  Calificacion { get; set; }
        public Boolean Estado { get; set; }
        public DateTime EstadoFecha { get; set; }
        [ForeignKey("Ricardo")]
        public int Idcarrera { get; set; }
        public Carrera Carrera { get; set; }
    }
}
