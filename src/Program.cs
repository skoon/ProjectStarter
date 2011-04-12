using System;


namespace ProjectStarter
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICommand command = getCommand(args);
            command.Execute();
        }
        public static ICommand getCommand(string[] args)
        {
            ArgParser parser = new ArgParser(args, new FileSystem(new DirectoryInfoWrapper(Environment.CurrentDirectory), new FileInfoWrapper()));
            return parser.Command;
        }
    }
}
