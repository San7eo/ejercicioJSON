
using System.Text.Json.Serialization;

using static PracticaJson.CEjercicio4.CProductos;

namespace PracticaJson
{
    public class CEjercicio4
    {   
        public List<CProductos> Productos {  get; set; }

        public CEjercicio4 ()
        {
            List<CProductos> product = new List<CProductos> ();
            List<string> eti = new List<string>();
            
        }
        public class CProductos
        {
            public string Nombre { get; set; }
            public float Precio { get; set; }

            public uint Existencias { get; set; }

            [JsonPropertyName("descuento_disponible")]
            public bool Descuento { get; set; }

            public List<string> Etiquetas { get; set; }

            public Detalle Detalles { get; set; }

            public class Detalle
            {
                public float Peso { get; set; }

                public CDimensiones Dimensiones { get; set; }

                public class CDimensiones
                {
                    public int Alto { get; set; }

                    public int Ancho { get; set; }

                    public int Profundidad { get; set; }
                }
            }

        }
    }
}
