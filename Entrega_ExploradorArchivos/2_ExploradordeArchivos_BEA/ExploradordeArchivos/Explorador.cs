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
    public partial class VentanaExplorador : Form
    {
        public VentanaExplorador()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"../..");

            if (info.Exists){
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
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
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories()){
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                {new ListViewItem.ListViewSubItem(item, "Directorio"),new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            foreach (FileInfo file in nodeDirInfo.GetFiles()){
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                { new ListViewItem.ListViewSubItem(item, "Fichero"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            //Añadimos los demás iconos
            foreach(FileInfo file in nodeDirInfo.GetFiles()){
                switch (file.Extension){
                    //Caso imagen
                    case ".jpg":
                    case ".png":
                    case ".gif":
                        {
                            item = new ListViewItem(file.Name, 2);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, "Img"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                            };
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        } 
                    break;
                
                    //Caso Archivo-Pdf
                    case ".pdf":
                    {
                            item = new ListViewItem(file.Name, 3);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, "PDF Documento"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                            };
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                    break;
                    
                   //Caso Archivo - C#
                    case ".cs":
                        {
                            item = new ListViewItem(file.Name, 4);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, "C# Archivo"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                            };
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        break;

                    //Caso Archivo -.EXE/Ejecutable
                    case ".exe":
                        {
                            item = new ListViewItem(file.Name, 6);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, "Ejecutable Archivo"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                            };
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        break;

                    //Caso Archivo - JAVA
                    case ".java":
                        {
                            item = new ListViewItem(file.Name, 7);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, "JAVA Archivo"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                            };
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        break;


                    //Caso Archivo - Python
                    case ".py":
                        {
                            item = new ListViewItem(file.Name, 8);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, "Python Archivo"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                            };
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        break;

                    //Caso Archivo Comprimido
                    case ".rar":
                    case ".zip":
                    case ".gz":
                        {
                            item = new ListViewItem(file.Name, 9);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, "C# Archivo"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                            };
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        break;

                    //Caso Archivo Comprimido
                    default:
                        {
                            item = new ListViewItem(file.Name, 5);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, "Archivo Desconocido"),
                                new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                            };
                            item.SubItems.AddRange(subItems);
                            listView1.Items.Add(item);
                        }
                        break;
                }
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        //MENU STRIP OPCIONES

            //Botón SALIR
            private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            //Iconos GRANDES
            private void iCONOSGRANDESToolStripMenuItem_Click(object sender, EventArgs e)
            {
                listView1.LargeImageList = imgListLarge;
                listView1.View = View.LargeIcon;
            }

            //Iconos PEQUEÑOS
            private void iCONOSPEQUEÑOSToolStripMenuItem_Click(object sender, EventArgs e)
            {
                listView1.SmallImageList = imgListSmall;
                listView1.View = View.SmallIcon;
            }

            //LISTA
            private void lISTAToolStripMenuItem_Click(object sender, EventArgs e)
            {
                 listView1.View = View.List;
            }

            //DETALLES
            private void dETALLESToolStripMenuItem_Click(object sender, EventArgs e)
            {
                 listView1.View = View.Details;
            }
        }
    }
