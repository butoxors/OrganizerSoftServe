namespace Organizer.Interfaces
{
    public interface IProcessRunable
    {
        void RunProcess(string processName);
        void RunProcess(string processName, string arguments = null);
    }
}
