using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("Medico")]
    public class Medico
    {
        public int MedicoId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }
        public int Matricula { get; set; }

        //Propiedad de navegacion
        public List<Paciente> Pacientes { get; set; }
        public int IdEspecialidad { get; set; }
        [ForeignKey("IdEspecialidad")]
        public Especialidad especialidad { get; set; }
    }
}
