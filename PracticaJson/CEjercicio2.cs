
using System.Text.Json.Serialization;


namespace PracticaJson
{
    public class CEjercicio2
    {
        public string Usuario {  get; set; }

        [JsonPropertyName("amigos_usuario")]
        public List<string> Amigos { get; set; }

        public CEjercicio2 () 
        { 
            List<string> list = new List<string>();
        }

        [JsonPropertyName("notificaciones_usuario")]
        public bool Notificaciones { get; set; }
       
    }
}
