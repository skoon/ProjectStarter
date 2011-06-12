using System;

namespace ProjectStarter {
    public interface ICommand {
        void Execute();
        string[] Args { get; set;}
        string Name { get; set;}
        IConfig Config { get; set; }
    }

    public class NewProject : ICommand {

        private readonly IFileSystem _fileSystem;

        public NewProject(IFileSystem FileSystem) {
            _fileSystem = FileSystem; 
        }

        public void Execute() {
            if (!String.IsNullOrEmpty(Args[0]))
                Config.RootDirectory = Args[0];
            _fileSystem.CreateDirectory(Config.RootDirectory);
            foreach (var dir in Config.SubDirectories) {
                _fileSystem.CreateDirectoryInWorkingDirectory(dir);
            }
        }

        public string[] Args {get; set;}
        public string Name {get; set;}
        public IConfig Config { get; set; }
    }
}

