using System;
using System.IO;

namespace _3REL
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            try
            {
                do
                {
                    Console.WriteLine("___________________________");
                    Console.WriteLine("1-Ejercicio");
                    Console.WriteLine("2-Ejercicio");
                    Console.WriteLine("3-Ejercicio");
                    Console.WriteLine("4-Ejercicio");
                    Console.WriteLine("5-Ejercicio");
                    Console.WriteLine("0_SALIR");
                    Console.WriteLine("___________________________");

                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {

                    //Comprueba si el directorio existe y si tiene ficheros dentro
                        case 1:
                            Console.Write("Indique la ruta del directorio: ");
                            String ruta = Console.ReadLine();

                            if (Directory.Exists(ruta))
                            {
                                //Creamos directoryinfo
                                DirectoryInfo directorio = new DirectoryInfo(ruta);

                                //Contamos archivos/ficheros
                                if(directorio.GetFiles().Length == 0)
                                {
                                    Console.WriteLine("La carpeta no contiene ningún archivo");
                                }

                                //Obtenemostodos los ficheros
                                FileInfo[] ficheros = directorio.GetFiles();
                                //VAR AUX
                                FileInfo ficheroMenorTam = new FileInfo(ruta);

                                //Buscamos el fichero de menor tamaño
                                for (int i = 0; i < ficheros.Length - 1; i++)
                                {
                                    if (ficheros[i].Length > ficheros[i + 1].Length)
                                    {
                                        ficheros[i] = ficheros[i + 1];
                                        ficheroMenorTam = ficheros[i];
                                    }
                                }

                                //Plasmamos los datos
                                if (ficheroMenorTam != null)
                                {
                                    long tam = ficheroMenorTam.Length / 1024;
                                    Console.WriteLine("El fichero de menor tamaño es '"  +ficheroMenorTam.Name+ "'\n"+
                                        "Y pesa:" +tam+ "KB");
                                }


                            }else { Console.WriteLine("Ruta incorrecta o Directorio inexistente"); }
                            break;

                    // Mostrar sólo ficheros con 'dicha' extension
                        case 2:
                            Console.Write("Indique la ruta del directorio: ");
                            String ruta2 = Console.ReadLine();

                            if (Directory.Exists(ruta2))
                            {
                                //Creamos directoryinfo
                                DirectoryInfo directorio = new DirectoryInfo(ruta2);

                                //Contamos archivos/ficheros
                                if (directorio.GetFiles().Length == 0)
                                {
                                    Console.WriteLine("La carpeta no contiene ningún archivo");
                                }

                                //Obtenemos el fichero de menor tamaño que se encuentre en el directorio
                                FileInfo[] ficheros = directorio.GetFiles();
                                
                                //Pedimos la extension del fichero
                                Console.WriteLine("Inserte extensión de fichero que desea: ");
                                String extension = "." + Console.ReadLine();

                                foreach(FileInfo file in ficheros)
                                {
                                    if (file.Extension == extension)
                                    {
                                        Console.WriteLine(file.Name);
                                    }
                                }
                            }
                            else { Console.WriteLine("Ruta incorrecta o Directorio inexistente"); }
                            break;
                    
                    // Crear un subdirectorio igual que el directorio
                        case 3:
                            Console.Write("Indique la ruta del directorio: ");
                            String ruta3 = Console.ReadLine();

                            if (Directory.Exists(ruta3))
                            {
                                //Creamos directoryinfo
                                DirectoryInfo directorio = new DirectoryInfo(ruta3);

                                Console.WriteLine("Vamos a crear un subdirectorio dentro del directorio, inserte el nombre: ");
                                String SubDirectorioNombre = Console.ReadLine();
                                DirectoryInfo subDir = directorio.CreateSubdirectory(SubDirectorioNombre);
                          
                                //Pedimos la extension del fichero
                                Console.WriteLine("Inserte extensión de ficheros que desea copiar en el directorio '" + SubDirectorioNombre+ ": ");
                                String extensionDir = "." + Console.ReadLine();

                                FileInfo[] ficheros = directorio.GetFiles();

                                foreach (FileInfo file in ficheros)
                                {
                                    if (file.Extension == extensionDir)
                                    {
                                        File.Copy(file.FullName, subDir.FullName + "\\" + file.Name);
                                    }
                                }

                            }
                            else { Console.WriteLine("Ruta incorrecta o Directorio inexistente"); }
                            break;
                    }

                } while (opcion != 0);
            }catch (FormatException e)
            {
                Console.WriteLine("Inserte un carácter numérico, por favor. " + e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error, desconocido" + e.Message);
            }
        }
    }
}
