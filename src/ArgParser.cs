using System;

namespace ProjectStarter
{
    public class ArgParser
    {
        public ICommand Command { get; set;}
        public ArgParser(string[] args, IFileSystem FileSystem)
        {
            
            if (args[0] == "controller")
            {

            }
        }
    }
}
