using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadez
{
    public class Medico : Persona
    {


        public Medico() { }
        public Medico(int id, string nombre, string apellido, string domicilio, string telefono, string email,string especialidad, int matricula) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Especialidad= especialidad;
            Matricula=matricula;
        }
        public string Especialidad { get; set; }
        public int Matricula { get; set; }
    }
}
