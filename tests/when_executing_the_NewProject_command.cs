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

        [Fact]
        public void the_src_directory_should_be_created() {
            Assert.Contains("src", mockFileSystem.directoriesCreated);
        }

        [Fact]
        public void the_tests_directory_should_be_created() {
            Assert.Contains("tests", mockFileSystem.directoriesCreated);
        }
   
       [Fact]
        public void the_lib_directory_should_be_created() {
           Assert.Contains("lib", mockFileSystem.directoriesCreated);
        } 

       [Fact]
        public void _the_wraps_directory_should_be_created() {
            Assert.Contains("wraps", mockFileSystem.directoriesCreated);
        }
    }
}
