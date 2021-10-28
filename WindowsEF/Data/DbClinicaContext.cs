using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;//Agregar
using WindowsEF.Models;

namespace WindowsEF.Data
{
    public class DbClinicaContext:DbContext //Agregar la herencia
    {
        //Constructor
        public DbClinicaContext() : base("KeyDbClinica") { }

        //Propiedades DbSet<m>
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
    }
}
