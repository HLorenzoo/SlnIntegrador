using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadez
{
    internal class Director : Persona
    {
        public Director() { }
        public Director(int id, string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, int matricula , string postgrado) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Especialidad = especialidad;
            Matricula = matricula;
            Postgrado = postgrado;
        }

        public string Especialidad { get; set; }
        public int Matricula { get; set; }
        public string Postgrado { get; set; }

    }
}
