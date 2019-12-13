using Organizer.Entities;
using Organizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            IOrganizer organizer = new Organizer(new APICaller(), new FileManager(), new ProcessRun());

            //organizer.APICall("https://google.com/");

            //organizer.RunProcess("notepad.exe");

            //organizer.OpenFile("pad.txt");

            organizer.RunProcess("calc.exe");

            Console.ReadKey();
        }
    }
}
