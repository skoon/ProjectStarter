using System;

namespace ProjectStarter
{
    public class ArgParser
    {
        public ICommand Command { get; set;}
        private IFileSystem _fileSystem;
        public ArgParser(string[] args, IFileSystem FileSystem) {
            if(FileSystem == null) throw  new ArgumentNullException("FileSystem can not be null");
            if(args != null) {
                _fileSystem = FileSystem;
                Command = new NewProject(FileSystem);
                Command.Args = args;
            }
        }        
    }
}
