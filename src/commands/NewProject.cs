using System;

namespace ProjectStarter {
    public interface ICommand {
        void Execute();
        string Name { get; set;}
        IConfig Config { get; set; }
    }

    public class NewProject : ICommand {

        private readonly IFileSystem _fileSystem;

        public NewProject(IFileSystem FileSystem) {
            _fileSystem = FileSystem; 
        }

        public void Execute() {
            if (!String.IsNullOrEmpty(Name))
                Config.RootDirectory = Name;
            _fileSystem.CreateDirectory(Config.RootDirectory);
            foreach (var dir in Config.SubDirectories) {
                _fileSystem.CreateDirectoryInWorkingDirectory(dir);
            }
        }
        public string Name {get; set;}
        public IConfig Config { get; set; }
    }
}

