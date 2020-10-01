using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ObtFich
{
    public partial class FormObtenerFicheros : Form
    {
        public FormObtenerFicheros()
        {
            InitializeComponent();
        }

        private void btnCargarFicheros_Click(object sender, EventArgs e)
        {
            String ruta = tbRuta.Text;
            Boolean rutaCorrecta = regexRuta(ruta);

            if (rutaCorrecta)
            {
                DirectoryInfo dInfo = new DirectoryInfo(ruta);

                //Ruta/Nombre del directorio
                listBoxFicheros.Items.Add(dInfo.FullName);
                //Salto de linea
                listBoxFicheros.Items.Add(" ");

                //Obtenemos los ficheros
                foreach (FileInfo file in dInfo.GetFiles())
                {
                    listBoxFicheros.Items.Add(file.Name + file.Extension + "\t\t\t\t" + file.CreationTime + "\t\t" + file.LastAccessTime);
                }

                //Obtenemos los directorios
                foreach (DirectoryInfo dir in dInfo.GetDirectories())
                {
                    listBoxFicheros.Items.Add(dir.Name + dir.Extension + "\t\t\t\t" + dir.CreationTime + "\t\t" + dir.LastAccessTime);
                }

            }else { MessageBox.Show("Error con la sintaxis","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //Método que nos comprueba  que la ruta empiece por 'C:\'
        private static Boolean regexRuta(String ruta)
        {
            String regexRuta = "^[CD]:\\\\";
            Regex expresionReg = new Regex(regexRuta);
            return expresionReg.IsMatch(ruta);

        }

    }
}
