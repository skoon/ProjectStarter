using System;
using Xunit;
using ProjectStarter;
using ProjectStarter_Tests.Mocks;

namespace ProjectStarter_Tests.UnitTests {

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
            Assert.Contains(projectname, mockFileSystem.DirectoriesCreated);
        }

        [Fact]
        public void the_src_directory_should_be_created() {
            Assert.Contains("src", mockFileSystem.DirectoriesCreated);
        }

        [Fact]
        public void the_tests_directory_should_be_created() {
            Assert.Contains("tests", mockFileSystem.DirectoriesCreated);
        }
   
       [Fact]
       public void the_lib_directory_should_be_created() {
           Assert.Contains("lib", mockFileSystem.DirectoriesCreated);
       } 

       [Fact]
       public void the_wraps_directory_should_be_created() {
            Assert.Contains("wraps", mockFileSystem.DirectoriesCreated);
       }

       [Fact]
       public void the_configs_directory_should_be_created() {
            Assert.Contains("configs", mockFileSystem.DirectoriesCreated);
       }
    }
}
