using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
namespace MyNote
{
    class LoadTreeView
    {
        public void GetDirectories(TreeNode TreNode, TreeNodeCollection TreNodeCollection,string PathOfDir)
        {
            DirectoryInfo[] DirNames;
            
            //TreNode.SelectedImageIndex the index of image and this if to sure that 
            // the image is not to rootnode and not to files so it will be to directory
            //and then open dir and get subdir and files
            if (TreNode.SelectedImageIndex!=0 && TreNode.SelectedImageIndex!=2)
            {
                try
                {
                    //to get directories
                    DirectoryInfo Directories = new DirectoryInfo(PathOfDir);
                    DirNames = Directories.GetDirectories();

                    foreach (DirectoryInfo DName in DirNames)
                    {
                        TreNode = new TreeNode(DName.Name,1,1);
                        TreNodeCollection.Add(TreNode);
                    }

                    //To get files from directory
                    GetFiles(TreNode, TreNodeCollection,PathOfDir);
                    
                }
                catch (Exception w)
                {

                    MessageBox.Show(w.ToString());
                } 
            }
        }


        private void GetFiles(TreeNode TreNode, TreeNodeCollection TreNodeCollection, string PathOfDir)
        {
            DirectoryInfo Files = new DirectoryInfo(PathOfDir);
            FileInfo[] FilesNames = Files.GetFiles();

            try
            {
                if (FilesNames.Count() > 0)
                {

                    foreach (FileInfo file in FilesNames)
                    {
                        TreNode = new TreeNode(file.Name,2,2);
                        TreNodeCollection.Add(TreNode);
                    }
                }
            }
            catch{}
 
        }
        
        private string GetName(string FullPathOfFileOrDir)
        {
            string[] Splitter = FullPathOfFileOrDir.Split('\\');
            int TheIndexOfName = Splitter.Length - 1;
            return Splitter[TheIndexOfName];
        }
        


    }

}