using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentManagementSystem
{
    public class FileManager
    {
        public void SaveToFile(string text)
        {
            File.WriteAllText("students.txt", text);
        }
        public string LoadFromFile()
        {
            return File.ReadAllText("students.txt");
        }
        public void CreateFile()
        {
            File.Create("students.txt").Close();
        }
    }
}
