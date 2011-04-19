using System;

namespace ProjectStarter {
    public interface ICommand {
        void Execute();
        string[] Args { get; set;}
        string Name { get; set;}
    }

    public class NewProject : ICommand {
       
        private IFileSystem _fileSystem;

        public NewProject(IFileSystem FileSystem) {
            _fileSystem = FileSystem; 
        }

        public void Execute() {
            _fileSystem.CreateDirectory(Args[0]);
            _fileSystem.CreateDirectoryInWorkingDirectory("src");
            _fileSystem.CreateDirectoryInWorkingDirectory("tests");
            _fileSystem.CreateDirectoryInWorkingDirectory("lib");
        }

        public string[] Args {get; set;}
        public string Name {get; set;}   
    }
}

