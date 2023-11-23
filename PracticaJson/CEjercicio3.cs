using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson
{
    public class CEjercicio3
    {
        public List<Estadistica> estadistica {  get; set; }
        
        public CEjercicio3()
        {
            List<Estadistica> estadisticas = new List<Estadistica>();
            List<CJugador> jugador = new List<CJugador>();
        }

        public class Estadistica
        {
            public string equipo { get; set; }
            public bool campeon { get; set; }
            public List<CJugador> jugadores { get; set; }
        }
    }
}
