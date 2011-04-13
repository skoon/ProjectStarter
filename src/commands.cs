using System;

namespace ProjectStarter {
    public interface ICommand {
        void Execute();
        string[] Args { get; set;}
        string Name { get; set;}
    }

    public class NewProject : ICommand {
        
        public void Execute() {
        
        }

        public string[] Args {get; set;}
        public string Name {get; set;}   
    }
}

