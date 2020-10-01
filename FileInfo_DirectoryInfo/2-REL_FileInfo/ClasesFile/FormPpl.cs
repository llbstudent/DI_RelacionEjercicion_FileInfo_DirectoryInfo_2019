using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesFile
{
    public partial class FormPpl : Form
    {
        public FormPpl()
        {
            InitializeComponent();
        }

        private void btnCrearTxt_Click(object sender, EventArgs e)
        {
            String nombreFichero = "textoFusion.txt";

            //Obtenemos la ruta del directorio actual
            DirectoryInfo directorioActual = new DirectoryInfo(Directory.GetCurrentDirectory());
            //Para redirigirme a la ruta
            tbRuta.Text = Directory.GetCurrentDirectory();

            //Obtenemos el número de ficheros en el directorio
            FileInfo[] ficheros = directorioActual.GetFiles();

            //Buscamos solo los ficheros txt
            foreach (FileInfo file in ficheros)
            {
                if (".txt" == file.Extension)
                {
                    StreamReader ficheroLectura = null;
                    StreamWriter ficheroEscritura = null;

                    //Nos creamos el archivo
                    if (File.Exists(nombreFichero))
                    {
                        ficheroEscritura = File.AppendText(nombreFichero);
                    }else{
                        ficheroEscritura = File.CreateText(nombreFichero);
                    }

                    //Leemos el contenido
                    ficheroLectura = file.OpenText();
                    String linea = ficheroLectura.ReadLine();

                    //Seguimos leyendo hasta que no encuentre ninguna línea
                    while (linea != null)
                    {
                        ficheroEscritura.WriteLine(linea);
                        linea = ficheroLectura.ReadLine();
                    }
                    //Cerramos los flujos
                    ficheroEscritura.Close();
                    ficheroEscritura.Close();
                }
            }
        }

        private void btnNorton1_Click(object sender, EventArgs e)
        {
            new FormNorton1().ShowDialog();
        }

        private void btnNorton2_Click(object sender, EventArgs e)
        {
            new Norton2().ShowDialog();
        }

        ////Método que nos comprueba  que la ruta empiece por 'C:\'
        //private static Boolean regexRuta(String ruta)
        //{
        //    String regexRuta = "^[CD]:\\\\";
        //    Regex expresionReg = new Regex(regexRuta);
        //    return expresionReg.IsMatch(ruta);

        //}

    }
}
