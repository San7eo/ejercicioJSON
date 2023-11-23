using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static PracticaJson.CEjercicio4.Productos;

namespace PracticaJson
{
    public class CEjercicio4
    {   
        public List<Productos> productos {  get; set; }

        public CEjercicio4 ()
        {
            List<Productos> product = new List<Productos> ();
            List<string> eti = new List<string>();
            
        }
        public class Productos
        {
            public string nombre { get; set; }
            public float precio { get; set; }

            public uint existencias { get; set; }

            [JsonPropertyName("descuento_disponible")]
            public bool descuento { get; set; }

            public List<string> etiquetas { get; set; }

            public Detalle detalles { get; set; }

            public class Detalle
            {
                public float peso { get; set; }

                public Dimensiones dimensiones { get; set; }

                public class Dimensiones
                {
                    public int alto { get; set; }

                    public int ancho { get; set; }

                    public int profundidad { get; set; }
                }
            }

        }
    }
}
