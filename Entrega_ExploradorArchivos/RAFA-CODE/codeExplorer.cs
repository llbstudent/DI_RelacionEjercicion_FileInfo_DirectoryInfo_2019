using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExploradordeArchivos
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
            
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;         
            DirectoryInfo info = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            try
            {
                if (info.Exists)
                {
                    rootNode = new TreeNode(info.Name);
                    rootNode.Tag = info;
                    GetDirectories(info.GetDirectories(), rootNode);
                    treeView1.Nodes.Add(rootNode);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);      
            }           
        }
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            try
            {
                TreeNode aNode;
                DirectoryInfo[] subSubDirs;
                foreach (DirectoryInfo subDir in subDirs)
                {
                    try
                    {
                        aNode = new TreeNode(subDir.Name, 0, 0);
                        aNode.Tag = subDir;
                        aNode.ImageKey = "Folder";
                        subSubDirs = subDir.GetDirectories();
                        if (subSubDirs.Length != 0)
                        {
                            GetDirectories(subSubDirs, aNode);
                        }
                        nodeToAddTo.Nodes.Add(aNode);
                    }
                    catch(UnauthorizedAccessException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                    
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                {new ListViewItem.ListViewSubItem(item, "Directorio"),new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                //Switch que usamos para validar tipo de extensión
                switch (file.Extension)
                {
                    case ".txt":
                        {
                            item = new ListViewItem(file.Name, 7); //Item con índice 7 (Ficheros)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Fichero"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".exe":
                        {
                            item = new ListViewItem(file.Name, 1); //Item con índice 1 (Archivos ejecutables)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Archivo ejecutable"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".png":
                    case ".jpg":
                    case ".gif":
                    case ".ico":
                        {
                            item = new ListViewItem(file.Name, 2); //Item con índice 2 (Imágenes)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Imagen"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".iso":
                        {
                            item = new ListViewItem(file.Name, 3); //Item con índice 2 (Imagen iso)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Imagen iso"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".pdf":
                        {
                            item = new ListViewItem(file.Name, 5); //Item con índice 5 (Documentos pdf)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Documento pdf"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".rar":
                    case ".zip":
                    case ".gz":
                        {
                            item = new ListViewItem(file.Name, 6); //Item con índice 6 (Archivo comprimido)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Archivo comprimido"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".bin":
                        {
                            item = new ListViewItem(file.Name, 8); //Item con índice 8 (Archivos binarios)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Archivo binario"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;
                    case ".mp3":
                        {
                            item = new ListViewItem(file.Name, 9); //Item con índice 9 (Archivos de audio mp3)
                            subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                            { new ListViewItem.ListViewSubItem(item, "Archivo mp3"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                            item.SubItems.AddRange(subItems); //Añade los subitems
                            listView1.Items.Add(item); //Añade el item completo a la listview
                        }
                        break;

                    default:
                        item = new ListViewItem(file.Name, 4); //Item con índice 4 (Otros archivos)
                        subItems = new ListViewItem.ListViewSubItem[] //Array de subitems
                        { new ListViewItem.ListViewSubItem(item, "Archivo"),//Esta línea establece texto a mostrar del item
                              new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())}; //Esta línea correponde a la info del último acceso al fichero
                        item.SubItems.AddRange(subItems); //Añade los subitems
                        listView1.Items.Add(item); //Añade el item completo a la listview
                        break;
                }
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Vista ICONOS PEQUEÑOS
        private void idIconosPequenios_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        //Vista ICONOS LISTA
        private void idLista_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        //Vista ICONOS GRANDES
        private void idIconosGrandes_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        //Vista DETALLES
        private void idDetalle_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        //Btn SALIR 
        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
