using System;
using System.Collections.Generic;
using System.Linq;
using ProjectStarter;
using ProjectStarter_Tests.Mocks;
using Xunit;

namespace ProjectStarter_Tests.UnitTests
{
    public class when_executing_a_command
    {
        public ICommand command;
        public MockFileSystem _mockFileSystem;
        public const string projectname = "test";

        public when_executing_a_command()
        {
            _mockFileSystem = new MockFileSystem() { ReturnFromReadFile = null };
            var parser = new ArgParser(new string[] { projectname }, _mockFileSystem);
            parser.Command.Execute();
        }


    }

}
