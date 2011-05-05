using System;
using Xunit;
using ProjectStarter;
using ProjectStarter_Tests.Mocks;


namespace ProjectStarter_Tests.UnitTests {

    public class when_parsing_arguments {
        
        public ArgParser parser;
        public when_parsing_arguments() {
            parser = new ArgParser(new string[] {"test"}, new MockFileSystem());
        }
    
        [Fact]
        public void the_command_property_should_be_set() {
            Assert.NotNull(parser.Command);
        }

        [Fact]
        public void the_command_property_should_be_the_correct_concrete_type() {
           Assert.IsType(typeof(NewProject), parser.Command); 
        }

        [Fact]
        public void and_passing_in_null_no_Command_should_be_set() {
            var p = new ArgParser(null, new MockFileSystem());
            Assert.Null(p.Command);
        }

        [Fact]
        public void should_throw_when_passed_a_null_FileSystem() {
            Assert.Throws<ArgumentNullException>(delegate {  new ArgParser(null, null);});
        }
    }
}
