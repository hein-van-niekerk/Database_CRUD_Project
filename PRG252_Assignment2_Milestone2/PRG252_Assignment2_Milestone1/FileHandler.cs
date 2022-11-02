using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG252_Assignment2_Milestone1
{
    internal class FileHandler
    {
        public FileHandler() { }

        public static string credential_file { get;set;}

        public void setFileLocation(string file)
        {
            credential_file = file; 
        }

        public string[] ReadFromFile()
        {
            string fileLocation = @"C:\Users\hein3\Desktop\PRG252\PRG252_Assignment2_Milestone2\PRG252_Assignment2_Milestone1\bin\Login_Credentials.txt";
            setFileLocation(fileLocation);
            string[] lines = File.ReadAllLines(fileLocation);
            return lines;
        }

        public void WriteToFile(string[] lines)
        {
            if (File.Exists(credential_file))
            {
                File.AppendAllLines(
                 credential_file,
                 lines);
            }
            else
            {
                File.WriteAllLines(credential_file, lines);

            }
            MessageBox.Show("Data written to file successfully");
        }


    }
}
