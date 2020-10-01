using System;
using System.IO;
using System.Security;
namespace FileInfo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = null;
            Console.WriteLine("Introduce un archivo: ");
            path = Console.ReadLine();
            Console.WriteLine();
            try
            {
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    Console.WriteLine("Nombre: {0}", file.Name);
                    Console.WriteLine("Nombre completo: {0}", file.FullName);
                    Console.WriteLine("Directorio padre: {0}", file.DirectoryName);
                    Console.WriteLine("Es de lectura: {0}", file.IsReadOnly);
                    Console.WriteLine("Tamaño: {0} bytes", file.Length);
                    Console.WriteLine("Atributos: {0}", file.Attributes);
                    Console.WriteLine("Creado: {0}", file.CreationTime);
                    Console.WriteLine("Leído: {0}", file.LastAccessTime);
                    Console.WriteLine("Modificado: {0}", file.LastWriteTime);
                }
                else
                {
                    Console.WriteLine("El archivo '{0}' no existe. ", path);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("El archivo '{0}' es inválido. {1}",path, ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("El archivo '{0}' tiene muchos caracteres. {1}",path, ex.Message);
            }
            catch (SecurityException ex)
            {
                Console.WriteLine("No tiene permiso para acceder a '{0}'. {1}",path, ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("El archivo '{0}' contiene caracteres inválidos. {1}",path, ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("El directorio '{0}' no está disponible. {1}",path, ex.Message);
            }
            Console.ReadKey(true);
        }