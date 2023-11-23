using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaJson
{
    public class CEjercicio2
    {
        public string usuario {  get; set; }

        [JsonPropertyName("amigos_usuario")]
        public List<string> amigos { get; set; }

        public CEjercicio2 () 
        { 
            List<string> list = new List<string>();
        }

        [JsonPropertyName("notificaciones_usuario")]
        public bool notificaciones { get; set; }
       
    }
}
