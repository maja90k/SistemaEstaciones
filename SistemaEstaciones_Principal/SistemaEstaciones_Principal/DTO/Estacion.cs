using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstaciones_DAL
{
    public class Estacion
    {
        private int idEstacion;
        private String direccion;
        private String region;
        private int capacidadMax;
        private String horarioAtencion;

        public int IdEstacion { get => idEstacion; set => idEstacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public string HorarioAtencion { get => horarioAtencion; set => horarioAtencion = value; }
        public string Region { get => region; set => region = value; }
    }
}
