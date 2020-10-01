using System;
using System.IO;


//Crea un  programa que  vaya leyendo  las frases  que el  usuario teclea  y las
//guarde en  un fichero  de texto  llamado  "registroDeUsuario.txt".  Terminará cuando  la
//frase introducida sea "fin" (esa frase no deberá guardarse en el fichero). 
public class Escritura
{
    public static void Main()
    {
        StreamWriter ficheroEsc;
        String nombreFichero;
        String frase = "";

        Console.Write("Dime el nombre del fichero: ");
        nombreFichero = Console.ReadLine();

        if (File.Exists(nombreFichero))
        {
            ficheroEsc = File.AppendText(nombreFichero);

        }
        else
        {
            ficheroEsc = File.CreateText(nombreFichero + ".txt");
            Console.WriteLine("El fichero '" + nombreFichero + "' ha sido creado");
        }

        while (frase != "fin")
        {
            Console.Write("Inserte Línea: ");

            //Para que no se escriba 'FIN' en el fichero
            if (frase != "fin")
            {
                frase = Console.ReadLine();
                ficheroEsc.WriteLine(frase);
            }
        }
        ficheroEsc.Close();
    }

}
