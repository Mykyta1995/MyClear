using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Shell32;
using System.IO;

namespace Clear
{
    /// <summary>
    /// class for save info recycle
    /// </summary>
    class Recycle : Delete
    {
        /// <summary>
        /// filed for save size files
        /// </summary>
        long size = 0;
        /// <summary>
        /// filed for save path file
        /// </summary>
        List<string> wayFile = new List<string>();
        /// <summary>
        /// filed for save path folder
        /// </summary>
        List<string> wayDirs = new List<string>();

        /// <summary>
        /// method for colled info or delete files
        /// </summary>
        /// <param name="flag">flag delete</param>
        /// <returns>information</returns>
        public string CallClear(bool flag)
        {
            Shell shell = new Shell();
            Shell32.Folder Recycler = shell.NameSpace(10);
            if (!flag)
            {
                bool acess = true;
                foreach (FolderItem file in Recycler.Items())
                {
                    if (File.GetAttributes(file.Path).ToString().Contains((FileAttributes.Directory).ToString()))
                    {
                        base.WalkDir(new DirectoryInfo(file.Path), "system", false, ref size, this.wayFile,ref acess);
                        this.wayDirs.Add(file.Path);
                    }
                    else
                    {
                        this.wayFile.Add(file.Path);
                        size += file.Size;
                    }

                }
            }
            else
            {
                MyDeleteFile.DeleteFiles(this.wayFile);
                foreach (var dir in this.wayDirs)
                {
                    try
                    {
                        Directory.Delete(dir, true);
                    }
                    catch (Exception e)
                    {
                        DirectoryInfo del = new DirectoryInfo(dir);
                        del.Attributes = FileAttributes.Normal;
                        try
                        {
                            del.Delete(true);
                        }
                        catch(Exception ex)
                        {

                        }
                        
                    }

                }
            }
            return string.Format("Recycle files: {0} KB:{1} File(-s)", this.size / 1000, this.wayFile.Count);
        }

        /// <summary>
        /// method for reset 
        /// </summary>
        public void Reset()
        {
            this.wayDirs.Clear();
            this.wayFile.Clear();
            this.size = 0;
        }

        /// <summary>
        /// method for get files
        /// </summary>
        public override List<string> GetSysytemFile
        {
            get
            {
                return this.wayFile;
            }
        }
    }
}
