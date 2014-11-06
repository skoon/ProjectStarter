using System;
using System.ComponentModel.Composition;

namespace ProjectStarter
{
    [Export(typeof(ICommand))]
    public class FetchPackage : ICommand
    {

        public void Execute()
        {
            
        }

        public string Name { get; set; }
        public IConfig Config { get; set; }

    }
}
