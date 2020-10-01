using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DirectoryInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNombreDir;
            string[] Archivos;
            DirectoryInfo  oDInfo;
            
            Console.WriteLine("Introducir un nombre de directorio");
            sNombreDir = Console.ReadLine();
            
            if (Directory.Exists(sNombreDir))
            {
                Console.WriteLine("Fecha último acceso: {0}",Directory.GetLastAccessTime(sNombreDir));
                Console.WriteLine("Archivos del directorio {0}", sNombreDir);
                Archivos = Directory.GetFiles(sNombreDir);
                
                foreach (string Archivo in Archivos){
                    Console.WriteLine(Archivo);
                }
                
                oDInfo = new DirectoryInfo(sNombreDir);
                oDInfo.CreateSubdirectory("bak");
                
            }else{
                Directory.CreateDirectory(sNombreDir);
                Console.WriteLine("No existía el directorio, se acaba de crear");
            }
            Console.ReadKey();        }
    }
}