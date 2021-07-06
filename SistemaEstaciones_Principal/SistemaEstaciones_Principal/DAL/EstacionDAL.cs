using SistemaEstaciones_Principal.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstaciones_Principal.DAL
{
    public class EstacionDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>();

        //static void Main()
        //{
        //}

        public void Add(Estacion e)
        {
            estaciones.Add(e);
        }

        public void Remove(int idEstacion)
        {
            Estacion estacion = estaciones.Find(e => e.IdEstacion == idEstacion);
            estaciones.Remove(estacion);
        }

        public List<Estacion> GetAll()
        {
            return estaciones;
        }

        public List<Estacion> GetAll(int idEstacion)
        {
            return estaciones.FindAll(e => e.IdEstacion == idEstacion);
        }

    }
}
