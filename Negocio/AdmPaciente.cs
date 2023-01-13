using Entidadez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {
            List<Paciente> listaPacientes = new List<Paciente>();


            listaPacientes.Add(new Paciente() 
            { 
                Id = 1, 
                Nombre = "Valeria", 
                Apellido = "López", 
                Domicilio = "Córdoba", 
                Email = "valeria@gmail.com",
                NroHistClinica = 001, 
                Telefono = "+54 295645478"
            });
            listaPacientes.Add(new Paciente()
            {
                Id = 2,
                Nombre = "Osvaldo",
                Apellido = "Gómez",
                Domicilio = "Buenos Aires",
                Email = "osvaldo@gmail.com",
                NroHistClinica = 002,
                Telefono = "+54 2923458996"
            });
            listaPacientes.Add(new Paciente()
            {
                Id = 3,
                Nombre = "Laura",
                Apellido = "Ramirez",
                Domicilio = "Corrientes",
                Email = "laura@gmail.com",
                NroHistClinica = 003,
                Telefono = "+54 295645478"
            });
            listaPacientes.Add(new Paciente()
            {
                Id = 4,
                Nombre = "Mario",
                Apellido = "González",
                Domicilio = "Mar del Plata",
                Email = "mario@gmail.com",
                NroHistClinica = 004,
                Telefono = "+54 2921568777"
            });
            listaPacientes.Add(new Paciente()
            {
                Id = 5,
                Nombre = "Camila",
                Apellido = "Rosales",
                Domicilio = "La Pampa",
                Email = "camila@gmail.com",
                NroHistClinica = 005,
                Telefono = "+54 2954412356"
            });

            return listaPacientes;
        }
        public static int Insertar(Paciente paciente)
        {
            //TODO...
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO...
            return 0;
        }
        public static Paciente TraerUno(int NroHistoriaClinica)
        {
            //TODO...
            return null;
        }

    }
}
