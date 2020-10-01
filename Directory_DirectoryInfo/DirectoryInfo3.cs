/*
el método GetDirectories( ) devuelve un array de cadenas, 
con los nombres de los subdirectorios que se encuentran dentro del directorio pasado como 
parámetro a este método. 
A continuación, mediante el método Move( ), cambiamos de lugar un directorio; 
con Delete( ) borramos otro de los directorios ...

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DirectoryInfo3
{
    class Program
    {
        static void Main(string[] args){
             string sNombreDir;
             DirectoryInfo oDirInfo;
             string[] sDirectorios;
             
            
            Console.WriteLine("Introducir un nombre de directorio");
            sNombreDir = Console.ReadLine();
            //obtener directorios del directorio especificado
            sDirectorios = Directory.GetDirectories(sNombreDir);
            
            //comprobar que el directorio contiene a su vez
            //varios directorios; en caso negativo, finalizar
            if (sDirectorios.Length < 1) {
                Console.WriteLine("El directorio especificado debe contener al menos dos subdirectorios");
                Console.ReadLine();

            }else{
                //mostrar nombres de directorios
                foreach (string sDirectorio in sDirectorios) { Console.WriteLine(sDirectorio);}
                //mover uno de los directorios a otra ubicación del disco actual
                Directory.Move(sDirectorios[0], ".\\temp\\BIS");
                //borrar otro de los directorios
                //el directorio a borrar debe estar vacío
                //comprobar con la siguiente expresión si dicho
                //directorio contiene o no archivos
                string[] archivos = Directory.GetFiles(sDirectorios[1]);

                if (archivos.Length >1){
                    Console.WriteLine("No se puede borrar el directorio: {0} - " + "contiene archivos", sDirectorios[1]);
                
                }else{ Directory.Delete(sDirectorios[1]);}
                
                Console.WriteLine("Completado");
                Console.ReadLine();
            }
        }
    }
}