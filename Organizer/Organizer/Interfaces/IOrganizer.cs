using System;

namespace Organizer.Interfaces
{
    public interface IOrganizer
    {
        // IFileManager
        void OpenFile(string path);

        // IProcessRunable
        void RunProcess(String name);

        // IAPIManager
        void APICall(string query);
    }
}
