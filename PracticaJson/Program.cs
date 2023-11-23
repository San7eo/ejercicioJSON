
using System;
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
            
            try
            {
                CEjercicio1 Ejercicio1 = JsonSerializer.Deserialize<CEjercicio1>(ejercicio1)!;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Hubo un error al leer el Json");
            }

            try 
            {
                CEjercicio2 Ejercicio2 = JsonSerializer.Deserialize<CEjercicio2>(ejercicio2)!;
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Hubo un error al leer el Json");
            }

            try
            {
                CEjercicio3 Ejercicio3 = JsonSerializer.Deserialize<CEjercicio3>(ejercicio3)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error al leer el Json");
            }

            try
            {
                CEjercicio4 Ejercicio4 = JsonSerializer.Deserialize<CEjercicio4>(ejercicio4)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error al leer el Json");
            }

        }
    }
}