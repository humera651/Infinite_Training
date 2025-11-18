using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{
    internal class FileHandlingDemo2
    {
        static void Main(string[] args)
        {
            //FileInfo file = new FileInfo(@"C:\Users\humeras\Infinite_Training\Training\DotNetTraining\test.txt");
            //if (!file.Exists)
            //{
            //    file.Create().Close();
            //}
            //Console.WriteLine(file.FullName);
            //file.CopyTo("C:\\Users\\humeras\\Infinite_Training\\Training\\DotNetTraining\\Dummy\\sample_backup.txt");
            //file.MoveTo("C:\\Users\\humeras\\Infinite_Training\\Training\\DotNetTraining\\sample.txt");

            //Specify the directory which we want to manipulate
            string sourcedir = @"C:\Users\humeras\Infinite_Training\Training\DotNetTraining\SampleSource";
            string targetdir = @"C:\Users\humeras\Infinite_Training\Training\DotNetTraining\SampleDestination";
            DirectoryInfo sdi = new DirectoryInfo(sourcedir);
            DirectoryInfo tdi = new DirectoryInfo(targetdir);
            //Check if target directory exists,if not,create it

            if (!tdi.Exists) 
            {
                tdi.Create();
            }

            //Copy each file into its new directory

            foreach (FileInfo fi in sdi.GetFiles())
            {
                fi.CopyTo(Path.Combine(tdi.ToString(), fi.Name), true);
                Console.WriteLine(@"Copying {0}\1",tdi.FullName,fi.Name);
            }

            //Copy each subdirectory and its files
            foreach (DirectoryInfo sourceSubDir in sdi.GetDirectories())
            {
                DirectoryInfo targetSubDir = tdi.CreateSubdirectory(sourceSubDir.Name);

                //Copy each file into its new directory
                foreach (FileInfo fi in sourceSubDir.GetFiles())
                {
                    fi.CopyTo(Path.Combine(targetSubDir.ToString(), fi.Name), true);
                    Console.WriteLine(@"Copying {0}\1", targetSubDir.FullName, fi.Name);
                }
            }
        }
    }
}
