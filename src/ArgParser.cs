using System;

namespace ProjectStarter
{
    public class ArgParser
    {
        public ICommand Command { get; set;}
        public ProjectStarterConfig Config { get; set; }

        public ArgParser(string[] args, IFileSystem FileSystem) {
            if(FileSystem == null) throw  new ArgumentNullException("FileSystem can not be null");
            Config = FileSystem.ReadFile("default.json");
            if(args != null) {
                Command = new NewProject(FileSystem);
                Command.Args = args;
            }
        }        
    }
}
