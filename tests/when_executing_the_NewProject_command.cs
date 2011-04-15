using System;
using Xunit;
using ProjectStarter;

namespace ProjectStarter_tests {

    public class when_executing_the_NewProject_command {
        
        public ICommand command;
        public MockFileSystem mockFileSystem = new MockFileSystem();
        public const string projectname = "test";

        public when_executing_the_NewProject_command() {
            var parser = new ArgParser(new string[] {projectname}, mockFileSystem); 
            parser.Command.Execute();

        }

        [Fact]
        public void the_project_directory_should_be_created() {
            Assert.Contains(projectname, mockFileSystem.directoriesCreated);
        }
    
    }
}
