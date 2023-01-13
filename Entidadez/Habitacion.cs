using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadez
{
    public class Habitacion
    {
        public Habitacion() { }

        public Habitacion(int id, int numero, bool ocupado)
        {
            Id = id;
            Numero = numero;
            Ocupado = ocupado;
        }

        public int Id { get; set; }
        public int Numero { get; set; }
        public bool Ocupado { get; set; }
    }
}
