using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesFile
{
    public partial class FormNorton1 : Form
    {
        public FormNorton1()
        {
            InitializeComponent();
            cargarListBox();
        }

        private void cargarListBox()
        {
            String[] nombreArchivos = Directory.GetFiles(Directory.GetCurrentDirectory());

            for(int i=0; i < nombreArchivos.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(nombreArchivos[i]));
            }
        }
    }
}
