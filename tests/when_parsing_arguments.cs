using System;
using System.Collections.Generic;
using Xunit;
using ProjectStarter;

namespace ProjectStarter_tests {

    public class MockFileSystem : IFileSystem {
        public string WorkingDirectory{get; set;}
        public bool CreateDirectoryCalled = false;
        public bool CreateFileCalled = false;
        public bool CreateDirectoryInWorkingDirectoryCalled = false;

        public List<string> directoriesCreated = new List<string>();
        
        public void CreateDirectory(string name) {
            CreateDirectoryCalled = true;
            directoriesCreated.Add(name);
        }
        
        public void CreateFile(string name, string contents) {
            CreateFileCalled = true;
        }
        
        public void CreateDirectoryInWorkingDirectory(string name) {
            CreateDirectoryInWorkingDirectoryCalled = true;
            directoriesCreated.Add(name);
        }
    }

    public class when_parsing_arguments {
        
        public ArgParser parser;
        public when_parsing_arguments() {
            parser = new ArgParser(new string[] {"test"}, new MockFileSystem());
        }
    
        [Fact]
        public void the_command_property_should_be_set() {
            Assert.NotNull(parser.Command);
        }

        public void the_command_property_should_be_the_correct_concrete_type() {
           Assert.IsType(typeof(NewProject), parser.Command); 
        }
    }

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
