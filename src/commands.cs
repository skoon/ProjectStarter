using System;

namespace ProjectStarter {
    public interface ICommand {
        void Execute();
        string[] Args { get; set;}
        string Name { get; set;}
    }

    public class NewProject : ICommand {
       
        private IFileSystem _fileSystem;
        private string[] _directorylist = new string[] { "src", "tests", "lib", "wraps" };

        public NewProject(IFileSystem FileSystem) {
            _fileSystem = FileSystem; 
        }

        public void Execute() {
            _fileSystem.CreateDirectory(Args[0]);
             createDirectories();
        }

        public void createDirectories() {
            foreach(string dir in _directorylist) {
                _fileSystem.CreateDirectoryInWorkingDirectory(dir);
            }
        }

        public string[] Args {get; set;}
        public string Name {get; set;}   
    }
}

