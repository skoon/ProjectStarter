using System;
using System.ComponentModel.Composition;

namespace ProjectStarter
{
    public interface ICommand
    {
        void Execute();
        string Name { get; set; }
        IConfig Config { get; set; }
    }
}