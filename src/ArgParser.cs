using System;

namespace ProjectStarter
{
    public class ArgParser
    {
        public ICommand Command { get; set;}
        public IConfig ProjectConfig { get; set; }

        public ArgParser(string[] args, IFileSystem FileSystem) {
            if(FileSystem == null) throw  new ArgumentNullException("FileSystem can not be null");
            string configFileContents = FileSystem.ReadFile("default.json");
            ProjectConfig = Config.LoadConfig(configFileContents);
            if(args != null) {
                Command = new NewProject(FileSystem);
                Command.Args = args;
            }
        }        
    }
}
