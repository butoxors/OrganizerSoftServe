using Organizer.Interfaces;
using System;
using System.Diagnostics;

namespace Organizer.Entities
{
    class ProcessRun : IProcessRunable
    {
        public void RunProcess(string processName, string arguments = null)
        {
            try
            {
                Process.Start(processName, arguments);
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }

        public void RunProcess(string processName)
        {
            this.RunProcess(processName, null);
        }
    }
}
