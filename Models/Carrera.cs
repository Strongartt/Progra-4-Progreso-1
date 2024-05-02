using System.ComponentModel.DataAnnotations;

namespace Progra_4_Progreso_1.Models
{
    public class Carrera
    {
        [Key]
       public int Idcarrera { get; set; }
        [Required]
        public string Nombre_carrera { get; set; }
       
        public string campus { get; set; }
        public int Numero_semestre { get; set; }
    }
}
