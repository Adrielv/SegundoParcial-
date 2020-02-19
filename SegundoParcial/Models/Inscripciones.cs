using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcial.Models
{
    public class Inscripciones
    {
        [Key]

        public int InscripcionId { get; set; }

        [Required(ErrorMessage ="No puede estar vacio")]        
        public string Semestre { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public int Limite { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public int Tomados { get; set; }
        [Required(ErrorMessage = "No puede estar vacio")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "No puede pasar el limite")]
        public int Disponibles { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles = 0;
        }
    }
}
