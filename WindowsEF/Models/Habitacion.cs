using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {
        
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(12)]
        public string Estado { get; set; }
        public int Id { get; set; }
        [ForeignKey("Id")]
        public Clinica clinica { get; set; }
    }
}