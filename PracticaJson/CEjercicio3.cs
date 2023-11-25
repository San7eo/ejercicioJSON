

namespace PracticaJson
{
    public class CEjercicio3
    {
        public List<CEstadistica> Estadistica {  get; set; }
        
        public CEjercicio3()
        {
            List<CEstadistica> estadisticas = new List<CEstadistica>();
            List<CJugador> jugador = new List<CJugador>();
        }

        public class CEstadistica
        {
            public string Equipo { get; set; }
            public bool Campeon { get; set; }
            public List<CJugador> Jugadores { get; set; }
        }
    }
}
