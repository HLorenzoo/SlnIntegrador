using Entidadez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmMedico
    {
        public static List<Medico> Listar()
        {
            List<Medico> listaMedicos = new List<Medico>();
            listaMedicos.Add(new Medico() 
            { 
                Id = 123, 
                Nombre = "Pedro",
                Apellido = "Gomez",
                Domicilio = "Misiones",
                Telefono = "+54 111545365",
                Email = "pedro@gmail.com",
                Especialidad = "Clinico",
                Matricula = 12345

            });
            listaMedicos.Add(new Medico()
            {
                Id = 1237,
                Nombre = "Rodrigo",
                Apellido = "Bueno",
                Domicilio = "Cordoba",
                Telefono = "+54 384653563",
                Email = "rodrigo@gmail.com",
                Especialidad = "Clinico",
                Matricula = 9898756

            });
            listaMedicos.Add(new Medico()
            {
                Id = 321,
                Nombre = "Hector",
                Apellido = "Perez",
                Domicilio = "Santa Fe",
                Telefono = "+54 3241563365",
                Email = "hector@gmail.com",
                Especialidad = "Cirujano",
                Matricula = 55564

            });
            listaMedicos.Add(new Medico()
            {
                Id = 2121,
                Nombre = "Pepe",
                Apellido = "Gutierrez",
                Domicilio = "Buenos Aires",
                Telefono = "+54 3414545",
                Email = "pepe@gmail.com",
                Especialidad = "Clinico",
                Matricula = 66666
            });
            listaMedicos.Add(new Medico()
            {
                Id = 31233,
                Nombre = "Juan",
                Apellido = "Silva",
                Domicilio = "Cordoba",
                Telefono = "+54 341452445",
                Email = "juan@gmail.com",
                Especialidad = "Cirujano",
                Matricula = 77777
            });

            return listaMedicos;
        }
        public static List<Medico> Listar(string especialidad)
        {
            //TODO...
            return null;
        }
        public static int Insertar(Medico medico)
        {
            //TODO...
            return 0;
        }
        public static int Eliminar (int id)
        {
            //TODO...
            return 0;
        }
        public static Medico TraerUno(int id)
        {
            //TODO...
            return null;
        }

        public static List<string> MedicosClinicos()
        {
            List<Medico> listaMedicos = AdmMedico.Listar();
            List<string> listaClinicos = new List<string>();

            foreach (Medico medico in listaMedicos)
            {
                if (medico.Especialidad == "Clinico")
                {
                    listaClinicos.Add($"{medico.Apellido} {medico.Nombre}");
                }
            }
            return listaClinicos;
        }

    }
}

    
