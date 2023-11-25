
using System;
using System.Collections;
using System.Text.Json;

namespace PracticaJson
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Carga del directorio de los JSON
            string pathEjercicioUno = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio1.json");
            string pathEjercicioDos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio2.json");
            string pathEjercicioTres = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio3.json");
            string pathEjercicioCuatro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ejercicio4.json");
            #endregion

            string ejercicio1 = File.ReadAllText(pathEjercicioUno);

            string ejercicio2 = File.ReadAllText(pathEjercicioDos);

            string ejercicio3 = File.ReadAllText(pathEjercicioTres);

            string ejercicio4 = File.ReadAllText(pathEjercicioCuatro);

            var option = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            try
            {
                CEjercicio1 Ejercicio1 = JsonSerializer.Deserialize<CEjercicio1>(ejercicio1, option)!;
                CEjercicio2 Ejercicio2 = JsonSerializer.Deserialize<CEjercicio2>(ejercicio2, option)!;
                CEjercicio3 Ejercicio3 = JsonSerializer.Deserialize<CEjercicio3>(ejercicio3, option)!;
                CEjercicio4 Ejercicio4 = JsonSerializer.Deserialize<CEjercicio4>(ejercicio4, option)!;
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("El argumento es null");
            }
            catch(JsonException ex)
            {
                Console.WriteLine(" Json invalido ");
            }
            catch(NotSupportedException ex)
            {
                Console.WriteLine(" El metodo invocado no tiene soportes ");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Hubo un error al leer el Json");
            }
        }
    }
}