using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicherosEjercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.ReadLine(); 

        }

        static void Ejercicio1()
        {
            Console.Write("Introduce el nombre del directorio que quieres borrar: ");
            string directorio = Console.ReadLine();

            if (Directory.Exists(directorio))
            {
                if (Directory.GetFiles(directorio).Length == 0 && Directory.GetDirectories(directorio).Length == 0)
                {
                    Directory.Delete(directorio);
                    Console.WriteLine("El directorio ha sido borrado correctamente.");
                }
                else
                {
                    Console.WriteLine("El directorio no está vacío. No se puede borrar.");
                }
            }
            else
            {
                Console.WriteLine("El directorio indicado no existe.");
            }
        }

        static void Ejercicio3()
        {
            Console.Write("Introduce el nombre/ruta del fichero: ");
            string ruta = Console.ReadLine();

            if (File.Exists(ruta))
            {
                FileInfo info = new FileInfo(ruta);
                Console.WriteLine("Nombre del fichero: " + info.Name);
                Console.WriteLine("Ruta canónica: " + info.FullName);
                Console.WriteLine("Tamaño del fichero: " + info.Length + " bytes");
            }
            else
            {
                FileStream stream = File.Create(ruta);
                stream.Close();
                Console.WriteLine("Se ha creado el fichero " + ruta);
            }
        }

        static void Ejercicio1FicherosTexto()
        {
            try
            {
                StreamReader sr = new StreamReader("D:\\probando.txt");
                {
                    string linea = sr.ReadLine();

                    while (linea != null)
                    {

                        Console.Write(linea.Replace(" ", ""));
                        linea = sr.ReadLine();
                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void Ejercicio2FicherosTexto()
        {
            string nombreFichero = "D:\\numeros.txt";
            int suma = 0;

            try
            {
                StreamReader sr = new StreamReader(nombreFichero);
                {
                    string linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        int numero = int.Parse(linea);
                        suma += numero;
                    }
                }

                Console.WriteLine("La suma de los números es: " + suma);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
