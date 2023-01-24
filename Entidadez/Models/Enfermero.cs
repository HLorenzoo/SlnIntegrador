using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadez
{
    public class Enfermero : Persona
    {
        public Enfermero() { }
        public Enfermero(int id, string nombre, string apellido, string domicilio, string telefono, string email, int cuil) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Cuil = cuil;
        }

        public int Cuil { get; set; }
       
    }
}
