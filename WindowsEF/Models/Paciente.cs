using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema; //Agregar- Si escribo [Table] me sugiere agregarlo wl vs
using System.ComponentModel.DataAnnotations;//Agregar- Si escribo [Required] el vs me recomienda el using

namespace WindowsEF.Models
{
    [Table("Paciente")]//EF cuando crea la tabla la llama Paciente en singular, sino por convension pluraliza el nombre a "Pacientes"
    public class Paciente
    {
        public int Id { get; set; }

        [Required]//Not null
        [Column(TypeName="varchar")]//tipo de dato de SQL Server
        [MaxLength(50)]//Maximo de caracteres
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }
        public int NroHistoriaClinica { get; set; }

        public int MedicoId { get; set; }//FK clave externa

        //Propiedad de navegacion
        [ForeignKey("MedicoId")]
        public Medico medico { get; set; }
    }
}
