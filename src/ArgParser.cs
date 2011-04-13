using System;

namespace ProjectStarter
{
    public class ArgParser
    {
        public ICommand Command { get; set;}
        private IFileSystem _fileSystem;
        public ArgParser(string[] args, IFileSystem FileSystem) {
            _fileSystem = FileSystem;
            Command = new NewProject(FileSystem);
            Command.Args = args;
        }        
    }
}
