using System;

namespace ProjectStarter {
    public class ArgParser {
        private const string _defaultConfig = @"{ ""RootDirectory"": ""New Project"", ""SubDirectories"": [""src"", ""lib"",""docs"",""tests"", ""configs"",""packages""] }";


        public ICommand Command { get; set; }
        public IConfig ProjectConfig { get; set; }

        public ArgParser(string[] args, IFileSystem FileSystem) {
            if (FileSystem == null) { throw new ArgumentNullException("FileSystem can not be null"); };
            string configFileContents = FileSystem.ReadFile("default.json");
            if(String.IsNullOrEmpty(configFileContents)) {
                FileSystem.CreateFile("default.json",_defaultConfig);
                configFileContents = _defaultConfig; 
            }
            ProjectConfig = Config.LoadConfig(configFileContents);
            if(args != null && !String.IsNullOrEmpty(args[0])) {
                Command = new NewProject(FileSystem) { Config=ProjectConfig, Name=args[0] };
            }
        }
    }
}
