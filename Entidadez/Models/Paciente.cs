using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadez
{
    public class Paciente:Persona
    {
        public Paciente() { }
        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email,int nroHistClinica): base(id,nombre,apellido,domicilio,telefono,email) 
        {
          NroHistClinica= nroHistClinica;
        }
        
        public int NroHistClinica { get; set; }
    }
}
