using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DirectoryInfo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir nombre de directorio");
            string sDirectorio;
            sDirectorio = Console.ReadLine();
            string[] sArchivos;
            sArchivos = Directory.GetFiles(sDirectorio);
            
            Console.WriteLine("Datos sobre archivos obtenidos del objeto Path");
            Console.WriteLine("==============================================");

            foreach (string sArchivo in sArchivos){
                Console.WriteLine("GetDirectoryName() {0}", 
                Path.GetDirectoryName(sArchivo));
                Console.WriteLine("GetExtension() {0}", Path.GetExtension(sArchivo));
                Console.WriteLine("GetFileName() {0}", Path.GetFileName(sArchivo));
                Console.WriteLine("GetFileNameWithoutExtension() {0}",Path.GetFileNameWithoutExtension(sArchivo));
                Console.WriteLine("GetFullPath() {0}", Path.GetFullPath(sArchivo));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}