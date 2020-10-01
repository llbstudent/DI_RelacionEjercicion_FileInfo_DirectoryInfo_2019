using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sNombreFich;
            StreamReader srLector;
            StreamWriter swEscritor;
            Console.WriteLine("Introducir ruta y archivo");
            sNombreFich = Console.ReadLine();
            if (File.Exists(sNombreFich))
            {
                srLector = File.OpenText(sNombreFich);
                Console.WriteLine("El archivo contiene:{0}{1}", srLector.ReadToEnd());
                srLector.Close();
            }
            else
            {
                swEscritor = File.CreateText(sNombreFich);
                swEscritor.WriteLine("este es");
                swEscritor.WriteLine("un nuevo archivo");
                swEscritor.Close();
            }   
            Console.WriteLine("Proceso finalizado");
            Console.ReadLine();
             
        }
    }
} 