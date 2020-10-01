using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileInfo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNombreFich;
            FileAttributes oAtributos;
            try
            {
                Console.WriteLine("Introducir ruta y archivo");
                sNombreFich = Console.ReadLine();
                oAtributos = File.GetAttributes(sNombreFich);
                Console.WriteLine("Atributos del archivo: {0}", oAtributos.ToString());
            }
            catch (FileNotFoundException oExcep)
            {
                Console.WriteLine("Se ha producido un error {0}", oExcep.Message);
            }
            finally
            {
                Console.WriteLine("Proceso finalizado");
                Console.ReadLine();
            }
        }     
    }
}