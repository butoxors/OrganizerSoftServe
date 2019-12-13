using Organizer.Interfaces;

namespace Organizer
{
    public class Organizer : IOrganizer
    {
        private IAPIManager APICaller;
        private IFileManager fileManager;
        private IProcessRunable processRunner;

        public Organizer(IAPIManager APIManager, IFileManager fileManager, IProcessRunable processRunable)
        {
            APICaller = APIManager;
            this.fileManager = fileManager;
            processRunner = processRunable;
        }

        public void APICall(string url)
        {
            APICaller.Call(url);
        }

        public void OpenFile(string path)
        {
            fileManager.OpenFile(path);
        }

        public void RunProcess(string name)
        {
            processRunner.RunProcess(name);
        }

    }
}
