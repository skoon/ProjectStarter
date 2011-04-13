using System;
using Xunit;
using ProjectStarter;

namespace ProjectStarter_tests {

    public class MockFileSystem : IFileSystem {
        public string WorkingDirectory{get; set;}
        public bool CreateDirectoryCalled = false;
        public bool CreateFileCalled = false;
        public bool CreateDirectoryInWorkingDirectoryCalled = false;
        
        public void CreateDirectory(string name) {
            CreateDirectoryCalled = true;
        }
        
        public void CreateFile(string name, string contents) {
            CreateFileCalled = true;
        }
        
        public void CreateDirectoryInWorkingDirectory(string name) {
            CreateDirectoryInWorkingDirectoryCalled = true;
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
            
        }
    }

}
