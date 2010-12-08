using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyNote.Properties;
using Microsoft.VisualBasic;
using System.IO;


namespace MyNote
{

    public partial class MAIN : Form
    {
       
        LoadTreeView loadTreView= new LoadTreeView();
        TreeNode TreNode;
        TreeNodeCollection TreCollec;
        FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();//To Hold The Main Path

        string NameOfNewFile;
        string FullPath;
        string HoldPathOfFileToEdit;//when i need to edit on the text in rich box use this path to save file after edit
        string ThePathOfDir = Settings.Default["ThePathOfDir"].ToString();
       
        
        public MAIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default["ThePathOfDir"].ToString() == string.Empty) 
            {
                MessageBox.Show("من فضلك حدد المجلد الرئيسى الذى به ملفاتك", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetChangeMainPath();
            }
            TreNode = new TreeNode("المحتويات");
            treeView1.Nodes.Add(TreNode);
            TreCollec = TreNode.Nodes;
            loadTreView.GetDirectories(TreNode, TreCollec, ThePathOfDir);
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            TreeNode CurrentNode = e.Node;

            string PathFromCurrentNode = CurrentNode.FullPath.ToString();
            PathFromCurrentNode = PathFromCurrentNode.Replace("tarek", "");
       
            CurrentNode.Nodes.Clear();
            FullPath=GetPath( ThePathOfDir+PathFromCurrentNode);

            loadTreView.GetDirectories(CurrentNode, CurrentNode.Nodes,FullPath);
           
          
         
            if (FileExtention(PathFromCurrentNode)=="rtf")
            {
                MessageBox.Show(FullPath);
                richTextBox1.LoadFile(FullPath);
                HoldPathOfFileToEdit = FullPath;
            }
            


        }


        private void GetChangeMainPath()
        {
            FolderBrowser.Description = "حدد المجلد الرئيسى";
           
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                
                ThePathOfDir = FolderBrowser.SelectedPath.ToString();
                Settings.Default["ThePathOfDir"] = ThePathOfDir;
                Settings.Default.Save();

            }
                   
        }

        private string FileExtention(string PathOfFile)
        {
            string[] Exten = PathOfFile.Split('.');
            int IndexOfExtention = Exten.Length - 1;
            return Exten[IndexOfExtention];
        }

        private string GetPath(string PathWhereMainFolderExist)
        {
            string FullPath = "";
            FullPath = PathWhereMainFolderExist.Replace("المحتويات", "");

            return FullPath;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MSChangeMainPath_Click(object sender, EventArgs e)
        {
            GetChangeMainPath();
        }

        private void TSSave_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty && Directory.Exists(FullPath))
            {


                NameOfNewFile = Interaction.InputBox("اكتب اسم الملف الذى تريد اضافته", "اضافه", "هنا اسم الملف", 400, 250).ToString();
                if (NameOfNewFile != string.Empty)
                {
                    richTextBox1.SaveFile(@FullPath + "\\" + NameOfNewFile + ".rtf");
                    MessageBox.Show(NameOfNewFile);
                }
            }
            else
            {
                MessageBox.Show("يجب ان تكتب موضوعا اولا قبل الحفظ وتتاكد من القسم الذى ستحفظ فيه الموضوع","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
               
            
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
             
        
            treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
            if (e.Button==MouseButtons.Right)
            {
                if (treeView1.SelectedNode.Text=="المحتويات")
                {
                    contextMenuStrip1.Items["CMSAddNewSubSection"].Enabled = false;
                    contextMenuStrip1.Items["CMSAddNewSection"].Enabled = true;
                }
                else
                {
                    contextMenuStrip1.Items["CMSAddNewSection"].Enabled = false; 
                    contextMenuStrip1.Items["CMSAddNewSubSection"].Enabled = true;
                }
 
                contextMenuStrip1.Show(treeView1, e.X, e.Y);

                
            }
          
          
        }

        private void CMSAddNewSection_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(FullPath + "\\NewSection");
           
            
        }

        private void CMSAddNewSubSection_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(FullPath + "\\NewSubSection");
        }
    }
}
