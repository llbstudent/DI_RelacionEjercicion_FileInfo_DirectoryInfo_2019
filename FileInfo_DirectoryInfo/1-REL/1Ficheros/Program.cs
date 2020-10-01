using System;
using System.IO;

namespace _1Ficheros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            String linea1, linea2;
            StreamWriter fichero1, fichero2;
            StreamReader ficheroLeer1, ficheroLeer2;

            try
            {
                do
                {
                    Console.WriteLine("SELECCIONE QUE DESEA HACER:");
                    Console.WriteLine("____________________________");
                    Console.WriteLine("1-Volcar contenido de un fichero a otro");
                    Console.WriteLine("2-Buscar frase");
                    Console.WriteLine("3-Duplicar/Copiar Fichero");
                    Console.WriteLine("4- Saber nota media.");
                    Console.WriteLine("5-Combinación 2 Ficheros. Mezcla de líneas");
                    Console.WriteLine("6- Suma enteros.txt");
                    Console.WriteLine("7-SALIR");
                    Console.WriteLine("____________________________");

                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        //VOLCAR CONTENIDO DE UN FICHERO A OTRO
                        case 1:
                            String nombreFicheroVolcado;
                            String nombreFicheroAVolcar;

                            Console.Write("Indique el nombre del fichero que quiere seleccionar: ");
                            nombreFicheroVolcado = Console.ReadLine() + ".txt";

                            if (File.Exists(nombreFicheroVolcado))
                            {
                                //Ahora sellecionamos donde queremos volcar los datos
                                Console.Write("Ahora seleccione el nombre donde quiere volcar los datos del fichero '" +nombreFicheroVolcado+ "': ");
                                nombreFicheroAVolcar = Console.ReadLine() +".txt";

                                //Comprobamos si existe, sino lo creamos
                                if (File.Exists(nombreFicheroAVolcar))
                                {
                                    fichero2 = File.AppendText(nombreFicheroAVolcar);
                                }
                                else{
                                    fichero2 = File.CreateText(nombreFicheroAVolcar);
                                }

                                //Leemos el contenido del fichero 'nombreFicheroVolcado'
                                ficheroLeer1 = File.OpenText(nombreFicheroVolcado);
                                linea1 = ficheroLeer1.ReadLine();
                                //Seguimos leyendo hasta que no encuentre ninguna línea
                                while(linea1 != null)
                                {
                                    fichero2.WriteLine(linea1);
                                    linea1 = ficheroLeer1.ReadLine();
                                }

                                //Cerramos los flujos
                                fichero2.Close();
                                ficheroLeer1.Close();
                            }
                            else { Console.WriteLine("Fichero no existente, seleccione otro, por favor."); }
                            break;

                        //Buscar frase en lineas de un fichero
                        case 2:
                            Console.Write("Que frase desea buscar: ");
                            String frase = Console.ReadLine().ToLower();

                            Console.Write("¿En qué fichero?: ");
                            String ficheroBuscaFrase = Console.ReadLine() +".txt";

                            if (File.Exists(ficheroBuscaFrase))
                            {
                                try
                                {
                                    StreamReader fichero = File.OpenText(ficheroBuscaFrase);
                                    //Leemos el Contenido
                                    String lineaFichero = fichero.ReadLine();
                                    int contadorLineas = 1;
                                    Boolean fraseEncontrada = false;

                                    while (lineaFichero != null)
                                    {
                                        lineaFichero = lineaFichero.ToLower();
                                        if (lineaFichero.Contains(frase))
                                        {
                                            Console.WriteLine(contadorLineas + "-Línea " + lineaFichero);
                                            fraseEncontrada = true;
                                        }
                                        lineaFichero = fichero.ReadLine();
                                        contadorLineas += 1;
                                    }

                                    if (!fraseEncontrada) { Console.WriteLine("No se encontraron resultados\n"); }
                                    fichero.Close();
                                }
                                catch (Exception) { Console.WriteLine(" "); }
                                

                            }else { Console.WriteLine("El fichero no existe"); }

                            break;


                        //Duplicar un fichero
                        case 3:
                            Console.Write("¿Qué fichero desea copiar?: ");
                            String nombreFicheroACopiar = Console.ReadLine()+".txt";

                            Console.Write("¿Cómo se llama el fichero donde va a plasmar los datos?: ");
                            String nuevoFicheroCopiado = Console.ReadLine() + ".txt";

                            if (File.Exists(nombreFicheroACopiar))
                            {
                                File.Copy(nombreFicheroACopiar, nuevoFicheroCopiado);
                            }else { Console.WriteLine("El Fichero no existe");}

                            break;

                        //Obtener la nota-media del grupo de matemáticas y escribirlas en un 'txt'
                        //Que nos muestre la nota más alta de informatica y el nombre del alumno
                        case 4:
                            if (File.Exists("notas.txt"))
                            {
                                //Var ayuda
                                StreamReader ficheroNotas = File.OpenText("notas.txt");
                                char[] separadores = {' '};
                                int contadorAlum = 1;

                                //Var para guardar datos
                                String nombreAlumnoNota = "";
                                float mediaGrupalMates = 0;
                                float notaMasAltaInformatica = 0;

                                //Aqui almacenaremos la linea
                                String lineaAlumnoNotas = ficheroNotas.ReadLine();

                                while (lineaAlumnoNotas != null)
                                {
                                    //Almacenaremos los datos de la linea en un array (por cada linea se ira sobreescribiendo)
                                    String[] datosAlumno = lineaAlumnoNotas.Split(separadores);

                                    //Recorremos los datos de ese alumno en cuestion
                                    for (int i = 0; i < datosAlumno.Length; i++)
                                    {
                                        switch (i)
                                        {
                                            case 1:
                                                if (notaMasAltaInformatica < float.Parse(datosAlumno[i])) //float.Parse(datosAlumno[i])
                                                {
                                                    notaMasAltaInformatica = float.Parse(datosAlumno[i]);
                                                    nombreAlumnoNota = datosAlumno[i-1].Trim();
                                                }
                                                break;

                                            case 2:
                                                mediaGrupalMates += float.Parse(datosAlumno[i]);
                                                break;
                                        }
                                    }
                                    contadorAlum += 1;
                                    lineaAlumnoNotas = ficheroNotas.ReadLine();
                                }
                                float media = mediaGrupalMates / contadorAlum;
                                Console.WriteLine("La media grupal de mates es: " + media);
                                Console.WriteLine("El alumno con más nota en informática es '" + nombreAlumnoNota + "', que tiene '" + notaMasAltaInformatica + "' de nota");
                                ficheroNotas.Close();

                            }
                            else { Console.WriteLine("Archivo no encontrado."); }

                            break;

                        case 5:
                            Console.WriteLine("Not ready");
                            break;

                        case 6:
                            Console.WriteLine("Not ready");
                            break;

                        case 7:
                            Console.WriteLine("ADIOS");
                            break;
                    }

                    } while (opcion > 0 && opcion < 7);

            }catch (FormatException e) {
                Console.WriteLine("Inserte un carácter numérico, por favor. " + e.Message);

            }catch (Exception e){
                Console.WriteLine("Error, desconocido. Ha saltao la excepcion " + e.Message);
            }
        }
    }
}
