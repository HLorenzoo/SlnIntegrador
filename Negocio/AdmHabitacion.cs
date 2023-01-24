using Entidadez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            Habitacion habitacion1 = new Habitacion(123, 1, true);
            Habitacion habitacion2 = new Habitacion(1234, 2, true);
            Habitacion habitacion3 = new Habitacion(1235, 3, false);
            Habitacion habitacion4 = new Habitacion(1236, 4, true);
            Habitacion habitacion5 = new Habitacion(1237, 5, false);

            listaHabitaciones.Add(habitacion1);
            listaHabitaciones.Add(habitacion2);
            listaHabitaciones.Add(habitacion3);
            listaHabitaciones.Add(habitacion4);
            listaHabitaciones.Add(habitacion5);

            return listaHabitaciones;
        }
        public static List<Habitacion> Listar(bool ocupado)
        {
            //TODO...
            return null;
        }
        public static int Insertar(Habitacion habitacion)
        {
            //TODO...
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO...
            return 0;
        }
        public static Habitacion TraerUno(int numero)
        {
            //TODO...
            return null;
        }

        public static List<string> HabitacionesEstado()
        {
            List<Habitacion> listaHabitaciones = AdmHabitacion.Listar();
            List<string> listEstadosHabitaciones = new List<string>();

            foreach (Habitacion habitacion in listaHabitaciones)
            {
                listEstadosHabitaciones.Add($"Habitacion: {habitacion.Numero} - Estado: {(habitacion.Ocupado? "Ocupada" : "Libre")}");
            }
            return listEstadosHabitaciones;
        }
    }
}
