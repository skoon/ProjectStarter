using System;
using System.ComponentModel.Composition;

namespace ProjectStarter
{

    [Export(typeof(ICommand))]
    public class MakeBuildFile : ICommand
    {

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
        public IConfig Config { get; set; }
    }
}
