using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileInfo3
{
    class Program
    {
        static void Main(string[] args) {
             string sNombreFich;
             int iOperacion;
             FileInfo  oFInfo;
              
            Console.WriteLine("Introducir ruta y archivo");
            sNombreFich = Console.ReadLine();
            Console.WriteLine("Fecha creación archivo: {0}",File.GetCreationTime(sNombreFich));
            oFInfo = new FileInfo(sNombreFich);
            
            Console.WriteLine("Introducir el número de operación a realizar:");
            Console.WriteLine("1 - Copiar");
            Console.WriteLine("2 - Mover");
            Console.WriteLine("3 - Borrar");
            iOperacion = Convert.ToInt32(Console.ReadLine());
            switch( iOperacion)
            {
                case 1:
                    File.Copy(sNombreFich, ".\\distinto"+ oFInfo.Extension);
                    break;
                case 2:
                    Console.WriteLine("Vamos a mover el archivo {0}", oFInfo.Name);
                    Console.WriteLine("que está en la ruta {0}", oFInfo.DirectoryName);
                    File.Move(sNombreFich, ".\\pruebas\\" + oFInfo.Name);
                    Console.WriteLine("Completado");
                    Console.ReadLine();
                    break;
                case 3:
                    File.Delete(sNombreFich);
                    break;
            }
        }
    }
}