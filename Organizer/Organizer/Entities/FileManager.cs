using Organizer.Interfaces;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Entities
{
    public class FileManager : IFileManager
    {
        private static IProcessRunable processRunner;

        static FileManager()
        {
            processRunner = new ProcessRun();
        }

        public void OpenFile(string path)
        {
            processRunner.RunProcess("notepad.exe", path);
        }

        /*public async void ReadFile(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    var data = new byte[fs.Length];

                    await fs.ReadAsync(data, 0, data.Length);

                    return Encoding.Default.GetString(data);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }*/
        /*
        public async void WriteFile(string path, string message)
        {
            try
            {
                using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    var data = Encoding.Default.GetBytes(message);

                    await fs.WriteAsync(data, 0, data.Length);

                    return true;
                }
            }catch(Exception ex) { Console.WriteLine(ex.StackTrace); }

            return false;
        }*/
    }
}
