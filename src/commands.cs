using System;

namespace ProjectStarter {
    public interface ICommand {
        void Execute();
        string[] Args { get; set;}
        string Name { get; set;}
    }

}
